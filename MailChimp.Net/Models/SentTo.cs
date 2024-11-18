// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SentTo.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The sent to.
/// </summary>
public class SentTo
{
    /// <summary>
    /// Gets or sets the absplit group.
    /// </summary>
    [JsonPropertyName("absplit_group")]
    public string AbsplitGroup { get; set; }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Gets or sets the email id.
    /// </summary>
    [JsonPropertyName("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the gmt offset.
    /// </summary>
    [JsonPropertyName("gmt_offset")]
    public int GmtOffset { get; set; }

    /// <summary>
    /// Gets or sets the last open.
    /// </summary>
    [JsonPropertyName("last_open")]
    public DateTime? LastOpen { get; set; }

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
    /// Gets or sets the open count.
    /// </summary>
    [JsonPropertyName("open_count")]
    public int OpenCount { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }
}