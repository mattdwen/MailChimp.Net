﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailActivity.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The email activity.
/// </summary>
public class EmailActivity
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailActivity"/> class.
    /// </summary>
    public EmailActivity()
    {
        Activity = new HashSet<MemberActivity>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the activity.
    /// </summary>
    [JsonPropertyName("activity")]
    public IEnumerable<MemberActivity> Activity { get; set; }

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
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }
}