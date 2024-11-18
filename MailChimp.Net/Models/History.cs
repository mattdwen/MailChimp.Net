// --------------------------------------------------------------------------------------------------------------------
// <copyright file="History.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The history.
/// </summary>
public class History
{
    /// <summary>
    /// Gets or sets the existing.
    /// </summary>
    [JsonPropertyName("existing")]
    public int Existing { get; set; }

    /// <summary>
    /// Gets or sets the imports.
    /// </summary>
    [JsonPropertyName("imports")]
    public int Imports { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the month.
    /// </summary>
    [JsonPropertyName("month")]
    public string Month { get; set; }

    /// <summary>
    /// Gets or sets the optins.
    /// </summary>
    [JsonPropertyName("optins")]
    public int Optins { get; set; }
}