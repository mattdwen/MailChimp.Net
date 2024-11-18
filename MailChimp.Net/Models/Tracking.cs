// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Tracking.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The tracking.
/// </summary>
public class Tracking
{
    /// <summary>
    /// Gets or sets the clicktale.
    /// </summary>
    [JsonPropertyName("clicktale")]
    public string Clicktale { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether ecomm 360.
    /// </summary>
    [JsonPropertyName("ecomm360")]
    public bool Ecomm360 { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether goal tracking.
    /// </summary>
    [JsonPropertyName("goal_tracking")]
    public bool GoalTracking { get; set; }

    /// <summary>
    /// Gets or sets the google analytics.
    /// </summary>
    [JsonPropertyName("google_analytics")]
    public string GoogleAnalytics { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether html clicks.
    /// </summary>
    [JsonPropertyName("html_clicks")]
    public bool HtmlClicks { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether opens.
    /// </summary>
    [JsonPropertyName("opens")]
    public bool Opens { get; set; }

    [JsonPropertyName("salesforce")]
    public SalesForce SalesForce { get; set; }

    [JsonPropertyName("highrise")]
    public HighRise HighRise { get; set; }

    [JsonPropertyName("capsule")]
    public Capsule Capsule { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether text clicks.
    /// </summary>
    [JsonPropertyName("text_clicks")]
    public bool TextClicks { get; set; }
}