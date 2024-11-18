// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ReportSummary.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The report summary.
/// </summary>
public class ReportSummary
{
    /// <summary>
    /// Gets or sets the click rate.
    /// </summary>
    [JsonPropertyName("click_rate")]
    public double ClickRate { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonPropertyName("clicks")]
    public int Clicks { get; set; }

    /// <summary>
    /// Gets or sets the open rate.
    /// </summary>
    [JsonPropertyName("open_rate")]
    public double OpenRate { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [JsonPropertyName("opens")]
    public int Opens { get; set; }

    /// <summary>
    /// Gets or sets the subscriber clicks.
    /// </summary>
    [JsonPropertyName("subscriber_clicks")]
    public int SubscriberClicks { get; set; }

    /// <summary>
    /// Gets or sets the unique opens.
    /// </summary>
    [JsonPropertyName("unique_opens")]
    public int UniqueOpens { get; set; }       

    [JsonPropertyName("ecommerce")]
    public Ecommerce Ecommerce { get; set; }

}