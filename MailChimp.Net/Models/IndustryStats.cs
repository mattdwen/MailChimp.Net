// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IndustryStats.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The industry stats.
/// </summary>
public class IndustryStats
{
    /// <summary>
    /// Gets or sets the abuse rate.
    /// </summary>
    [JsonPropertyName("abuse_rate")]
    public double AbuseRate { get; set; }

    /// <summary>
    /// Gets or sets the bounce rate.
    /// </summary>
    [JsonPropertyName("bounce_rate")]
    public double BounceRate { get; set; }

    /// <summary>
    /// Gets or sets the click rate.
    /// </summary>
    [JsonPropertyName("click_rate")]
    public double ClickRate { get; set; }

    /// <summary>
    /// Gets or sets the open rate.
    /// </summary>
    [JsonPropertyName("open_rate")]
    public double OpenRate { get; set; }

    /// <summary>
    /// Gets or sets the result.
    /// </summary>
    [JsonPropertyName("type")]
    public string Result { get; set; }

    /// <summary>
    /// Gets or sets the unopen rate.
    /// </summary>
    [JsonPropertyName("unopen_rate")]
    public double UnopenRate { get; set; }

    /// <summary>
    /// Gets or sets the unsub rate.
    /// </summary>
    [JsonPropertyName("unsub_rate")]
    public double UnsubRate { get; set; }
}