// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Content.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The content.
/// </summary>
public class Content
{
    /// <summary>
    /// Gets or sets the html.
    /// </summary>
    [JsonPropertyName("html")]
    public string Html { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// </summary>
    [JsonPropertyName("variate_contents")]
    public IEnumerable<VariateContents> VariateContents { get; set; }

    /// <summary>
    /// Gets or sets the plain text.
    /// </summary>
    [JsonPropertyName("plain_text")]
    public string PlainText { get; set; }

    /// <summary>
    /// The Archive HTML for the campaign.
    /// </summary>
    [JsonPropertyName("archive_html")]
    public string ArchiveHtml { get; set; }
}