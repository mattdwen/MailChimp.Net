// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Link.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Core;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The link.
/// </summary>
public class Link
{
    /// <summary>
    /// Gets or sets the href.
    /// </summary>
    [JsonPropertyName("href")]
    public string Href { get; set; }

    /// <summary>
    /// Gets or sets the method.
    /// </summary>
    [JsonPropertyName("method")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<Method>))]
    public Method Method { get; set; }

    /// <summary>
    /// Gets or sets the rel.
    /// </summary>
    [JsonPropertyName("rel")]
    public string Rel { get; set; }

    /// <summary>
    /// Gets or sets the schema.
    /// </summary>
    [JsonPropertyName("schema")]
    public string Schema { get; set; }

    /// <summary>
    /// Gets or sets the target schema.
    /// </summary>
    [JsonPropertyName("targetSchema")]
    public string TargetSchema { get; set; }
}