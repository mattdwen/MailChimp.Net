// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Report.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The report.
/// </summary>
public class Report
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Report"/> class.
    /// </summary>
    public Report()
    {
        Timeseries = new HashSet<Timesery>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the abuse reports.
    /// </summary>
    [JsonPropertyName("abuse_reports")]
    public int AbuseReports { get; set; }

    /// <summary>
    /// Gets or sets the bounces.
    /// </summary>
    [JsonPropertyName("bounces")]
    public Bounces Bounces { get; set; }

    /// <summary>
    /// Gets or sets the campaign title.
    /// </summary>
    [JsonPropertyName("campaign_title")]
    public string CampaignTitle { get; set; }


    [JsonPropertyName("subject_line")]
    public string SubjectLine { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonPropertyName("clicks")]
    public Clicks Clicks { get; set; }

    /// <summary>
    /// Gets or sets the delivery status.
    /// </summary>
    [JsonPropertyName("delivery_status")]
    public DeliveryStatus DeliveryStatus { get; set; }

    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [JsonPropertyName("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the facebook likes.
    /// </summary>
    [JsonPropertyName("facebook_likes")]
    public FacebookLikes FacebookLikes { get; set; }

    /// <summary>
    /// Gets or sets the forwards.
    /// </summary>
    [JsonPropertyName("forwards")]
    public Forwards Forwards { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the industry stats.
    /// </summary>
    [JsonPropertyName("industry_stats")]
    public IndustryStats IndustryStats { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list stats.
    /// </summary>
    [JsonPropertyName("list_stats")]
    public ListStats ListStats { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [JsonPropertyName("opens")]
    public Opens Opens { get; set; }

    /// <summary>
    /// Gets or sets the send time.
    /// </summary>
    [JsonPropertyName("send_time")]
    public string SendTime { get; set; }

    /// <summary>
    /// Gets or sets the share report.
    /// </summary>
    [JsonPropertyName("share_report")]
    public ShareReport ShareReport { get; set; }

    /// <summary>
    /// Gets or sets the timeseries.
    /// </summary>
    [JsonPropertyName("timeseries")]
    public IEnumerable<Timesery> Timeseries { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<CampaignType>))]
    public CampaignType Type { get; set; }

    /// <summary>
    /// Gets or sets the unsubscribed.
    /// </summary>
    [JsonPropertyName("unsubscribed")]
    public int Unsubscribed { get; set; }
}