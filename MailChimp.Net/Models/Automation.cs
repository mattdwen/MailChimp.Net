// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Automation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The automation.
/// </summary>
public class Automation
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Automation"/> class.
    /// </summary>
    public Automation()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the create time.
    /// </summary>
    [JsonPropertyName("create_time")]
    public string CreateTime { get; set; }

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
		[JsonConverter(typeof(StringEnumDescriptionConverter<AutomationStatus>))]
    public AutomationStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the tracking.
    /// </summary>
    [JsonPropertyName("tracking")]
    public Tracking Tracking { get; set; }

    /// <summary>
    /// Gets or sets the trigger settings.
    /// </summary>
    [JsonPropertyName("trigger_settings")]
    public TriggerSettings TriggerSettings { get; set; }
}