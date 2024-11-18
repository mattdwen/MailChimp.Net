// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EepUrlActivity.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The eep url activity.
/// </summary>
public class EepUrlActivity
{
    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonPropertyName("clicks")]
    public IEnumerable<EepClick> Clicks { get; set; }

    /// <summary>
    /// Gets or sets the eep url.
    /// </summary>
    [JsonPropertyName("eepurl")]
    public string EepUrl { get; set; }

    /// <summary>
    /// Gets or sets the referrers.
    /// </summary>
    [JsonPropertyName("referrers")]
    public IEnumerable<Referrer> Referrers { get; set; }

    /// <summary>
    /// Gets or sets the total items.
    /// </summary>
    [JsonPropertyName("total_items")]
    public string TotalItems { get; set; }

    /// <summary>
    /// Gets or sets the twitter.
    /// </summary>
    [JsonPropertyName("twitter")]
    public Twitter Twitter { get; set; }
}