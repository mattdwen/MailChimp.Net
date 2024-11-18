// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Condition.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The condition.
/// </summary>
public class Condition
{
    /// <summary>
    /// Gets or sets the field.
    /// </summary>
    [JsonPropertyName("field")]
    public string Field { get; set; }

    [JsonPropertyName("condition_type")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<ConditionType>))]
    public ConditionType Type { get; set; }

    [JsonPropertyName("op")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<Operator>))]
    public Operator Operator { get; set; }

    [JsonPropertyName("extra")]
    public string Extra { get; set; }

    /// <summary>
    /// Gets or sets the value.
    /// </summary>
    [JsonPropertyName("value")]
    public dynamic Value { get; set; }
}