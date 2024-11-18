// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringEnumDescriptionConverter.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The string enum description converter.
/// </summary>
public class StringEnumDescriptionConverter<T> : JsonConverter<T> where T : Enum
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StringEnumDescriptionConverter"/> class.
    /// Initializes a new instance of the <see cref="T:Newtonsoft.Json.Converters.StringEnumConverter"/> class.
    ///
    /// </summary>
    public StringEnumDescriptionConverter()
    {
        AllowIntegerValues = true;
    }

    /// <summary>
    /// Gets or sets a value indicating whether integer values are allowed.
    ///
    /// </summary>
    ///
    /// <value>
    /// <c>true</c> if integers are allowed; otherwise, <c>false</c>.
    /// </value>
    public bool AllowIntegerValues { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether camel case text.
    /// </summary>
    public bool CamelCaseText { get; set; }

    /// <summary>
    /// The can convert.
    /// </summary>
    /// <param name="objectType">
    /// The object type.
    /// </param>
    /// <returns>
    /// The <see cref="bool"/>.
    /// </returns>
    public override bool CanConvert(Type objectType) => objectType.GetTypeInfo().IsEnum;

    /// <summary>
    /// The read json.
    /// </summary>
    /// <param name="reader">
    /// The reader.
    /// </param>
    /// <param name="typeToConvert">
    /// The object type.
    /// </param>
    /// <param name="options">
    /// The serializer options.
    /// </param>
    /// <returns>
    /// The <see cref="object"/>.
    /// </returns>
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType != JsonTokenType.String)
        {
            throw new JsonException($"Unexpected token type {reader.TokenType}, expected a string.");
        }

        var enumString = reader.GetString();
        var underlyingType = Nullable.GetUnderlyingType(typeToConvert) ?? typeToConvert;

        // Find a matching description
        var enumField = underlyingType
            .GetFields(BindingFlags.Public | BindingFlags.Static)
            .FirstOrDefault(field =>
            {
                var descriptionAttribute = field.GetCustomAttribute<DescriptionAttribute>();
                return descriptionAttribute != null && descriptionAttribute.Description.Equals(enumString, StringComparison.OrdinalIgnoreCase);
            });

        if (enumField != null)
        {
            return (T)Enum.Parse(underlyingType, enumField.Name);
        }

        // Fallback to matching the enum name (case insensitive)
        var matchingEnumNames = Enum.GetNames(underlyingType)
                                    .FirstOrDefault(name => name.Equals(enumString, StringComparison.OrdinalIgnoreCase));

        if (matchingEnumNames != null)
        {
            return (T)Enum.Parse(underlyingType, matchingEnumNames);
        }

        throw new JsonException($"Unable to convert \"{enumString}\" to {underlyingType.Name}.");
    }

    /// <summary>
    /// Writes the JSON representation of the object.
    ///
    /// </summary>
    /// <param name="writer">
    /// The <see cref="T:System.Text.Json.Utf8JsonWriter"/> to write to.
    /// </param>
    /// <param name="value">
    /// The value.
    /// </param>
    /// <param name="options">
    /// The serializer options.
    /// </param>

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        var type = typeof(T);
        var name = Enum.GetName(type, value);

        if (string.IsNullOrWhiteSpace(name))
        {
            writer.WriteNullValue();
            return;
        }

        var description = type.GetField(name)
                              .GetCustomAttributes<DescriptionAttribute>(false)
                              .Select(attr => attr.Description)
                              .SingleOrDefault();

        writer.WriteStringValue(description ?? name);
    }
}