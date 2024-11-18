// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Clicks.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The clicks.
/// </summary>
public class Clicks
{
    /// <summary>
    /// Gets or sets the click rate.
    /// </summary>
    [JsonPropertyName("click_rate")]
    public double ClickRate { get; set; }

    /// <summary>
    /// Gets or sets the clicks total.
    /// </summary>
    [JsonPropertyName("clicks_total")]
    public int ClicksTotal { get; set; }

    /// <summary>
    /// Gets or sets the last click.
    /// </summary>
    [JsonPropertyName("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// Gets or sets the unique clicks.
    /// </summary>
    [JsonPropertyName("unique_clicks")]
    public int UniqueClicks { get; set; }

    /// <summary>
    /// Gets or sets the unique subscriber clicks.
    /// </summary>
    [JsonPropertyName("unique_subscriber_clicks")]
    public int UniqueSubscriberClicks { get; set; }
}