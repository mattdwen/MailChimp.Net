// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Unsubscribe.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The unsubscribe.
/// </summary>
public class Unsubscribe
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Unsubscribe"/> class.
    /// </summary>
    public Unsubscribe()
    {
        Links = new HashSet<Link>();
    }

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

    /// <summary>
    /// Gets or sets the reason.
    /// </summary>
    [JsonPropertyName("reason")]
    public string Reason { get; set; }

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; }
}