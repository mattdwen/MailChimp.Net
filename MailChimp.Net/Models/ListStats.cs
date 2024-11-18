// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListStats.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The list stats.
/// </summary>
public class ListStats
{
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
    /// Gets or sets the sub rate.
    /// </summary>
    [JsonPropertyName("sub_rate")]
    public double SubRate { get; set; }

    /// <summary>
    /// Gets or sets the unsub rate.
    /// </summary>
    [JsonPropertyName("unsub_rate")]
    public double UnsubRate { get; set; }
}