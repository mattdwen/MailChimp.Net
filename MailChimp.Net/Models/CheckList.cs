// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CheckList.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The check list.
/// </summary>
public class CheckList
{
    /// <summary>
    /// Gets or sets the details.
    /// </summary>
    [JsonPropertyName("details")]
    public string Details { get; set; }

    /// <summary>
    /// Gets or sets the heading.
    /// </summary>
    [JsonPropertyName("heading")]
    public string Heading { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [JsonPropertyName("type")]
    public Core.Result Type { get; set; }
}