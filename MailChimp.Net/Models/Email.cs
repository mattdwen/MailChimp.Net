// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Email.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The email.
/// </summary>
public class Email
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Email"/> class.
    /// </summary>
    public Email()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the archive url.
    /// </summary>
    [JsonPropertyName("archive_url")]
    public string ArchiveUrl { get; set; }

    /// <summary>
    /// Gets or sets the content type.
    /// </summary>
    [JsonPropertyName("content_type")]
    public string ContentType { get; set; }

    /// <summary>
    /// Gets or sets the create time.
    /// </summary>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; }

    /// <summary>
    /// Gets or sets the delay.
    /// </summary>
    [JsonPropertyName("delay")]
    public Delay Delay { get; set; }

    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [JsonPropertyName("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the position.
    /// </summary>
    [JsonPropertyName("position")]
    public int Position { get; set; }

    /// <summary>
    /// Gets or sets the recipients.
    /// </summary>
    [JsonPropertyName("recipients")]
    public Recipient Recipients { get; set; }

    /// <summary>
    /// Gets or sets the report summary.
    /// </summary>
    [JsonPropertyName("report_summary")]
    public ReportSummary ReportSummary { get; set; }

    /// <summary>
    /// Gets or sets the send time.
    /// </summary>
    [JsonPropertyName("send_time")]
    public string SendTime { get; set; }

    /// <summary>
    /// Gets or sets the settings.
    /// </summary>
    [JsonPropertyName("settings")]
    public Setting Settings { get; set; }

    /// <summary>
    /// Gets or sets the start time.
    /// </summary>
    [JsonPropertyName("start_time")]
    public string StartTime { get; set; }

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
    /// Gets or sets the workflow id.
    /// </summary>
    [JsonPropertyName("workflow_id")]
    public string WorkflowId { get; set; }
    
    /// <summary>
    /// Gets or sets the web id.
    /// </summary>
    [JsonPropertyName("web_id")]
    public int WebId { get; set; }
}
