// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Open.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

using System;
using System.Collections.Generic;

namespace MailChimp.Net.Models;

/// <summary>
/// The Open.
/// </summary>
public class Open
{
    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the email id.
    /// </summary>
    [JsonPropertyName("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the merge fields.
    /// </summary>
    [JsonPropertyName("merge_fields")]
    public Dictionary<string, object> MergeFields { get; set; }

    /// <summary>
    /// Gets or sets the vip.
    /// </summary>
    [JsonPropertyName("vip")]
    public bool VIP { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonPropertyName("opens_count")]
    public int OpensCount { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonPropertyName("opens")]
    public TimeStamp[] Opens  { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

}