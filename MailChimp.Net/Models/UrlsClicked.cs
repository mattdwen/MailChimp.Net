// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UrlsClicked.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The url clicked.
/// </summary>
public class UrlClicked
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UrlClicked"/> class.
    /// </summary>
    public UrlClicked()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the click percentage.
    /// </summary>
    [JsonPropertyName("click_percentage")]
    public double ClickPercentage { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the last click.
    /// </summary>
    [JsonPropertyName("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the total clicks.
    /// </summary>
    [JsonPropertyName("total_clicks")]
    public int TotalClicks { get; set; }

    /// <summary>
    /// Gets or sets the unique click percentage.
    /// </summary>
    [JsonPropertyName("unique_click_percentage")]
    public double UniqueClickPercentage { get; set; }

    /// <summary>
    /// Gets or sets the unique clicks.
    /// </summary>
    [JsonPropertyName("unique_clicks")]
    public int UniqueClicks { get; set; }

    /// <summary>
    /// Gets or sets the url.
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }
}