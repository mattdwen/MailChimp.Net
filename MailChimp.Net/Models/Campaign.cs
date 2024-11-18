// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Campaign.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using MailChimp.Net.Core;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The campaign.
/// </summary>
public class Campaign
{
    /// <summary>
    /// Gets or sets the archive url.
    /// </summary>
    [JsonPropertyName("archive_url")]
    public string ArchiveUrl { get; set; }

    /// <summary>
    /// Gets or sets the long archive url.
    /// </summary>
    [JsonPropertyName("long_archive_url")]
    public string LongArchiveUrl { get; set; }

    /// <summary>
    /// Gets or sets the content type.
    /// </summary>
    [JsonPropertyName("content_type")]
    public string ContentType { get; set; }

    /// <summary>
    /// Gets or sets the create time.
    /// </summary>
    [JsonPropertyName("create_time")]
    public DateTime CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the delivery status.
    /// </summary>
    [JsonPropertyName("delivery_status")]
    public DeliveryStatus DeliveryStatus { get; set; }

    [JsonPropertyName("rss_opts")]
    public RssOptions RssOptions { get; set; }

    [JsonPropertyName("social_card")]
    public SocialCard SocialCard { get; set; }

    [JsonPropertyName("report_summary")]
    public ReportSummary ReportSummary { get; set; }

    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [JsonPropertyName("emails_sent")]
    public int? EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the web id.
    /// </summary>
    [JsonPropertyName("web_id")]
    public int WebId { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the recipients.
    /// </summary>
    [JsonPropertyName("recipients")]
    public Recipient Recipients { get; set; }

    /// <summary>
    /// Gets or sets the send time.
    /// </summary>
    [JsonPropertyName("send_time")]
    public DateTime? SendTime { get; set; }

    /// <summary>
    /// Gets or sets the settings.
    /// </summary>
    [JsonPropertyName("settings")]
    public Setting Settings { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or sets the tracking.
    /// </summary>
    [JsonPropertyName("tracking")]
    public Tracking Tracking { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<CampaignType>))]
    public CampaignType Type { get; set; }

    [JsonPropertyName("dashboard_link")]
    public string DashboardLink { get; internal set; }

    [JsonPropertyName("variate_settings")]
    public VariateSettings VariateSettings { get; set; }
}
