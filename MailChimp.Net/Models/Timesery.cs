// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Timesery.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The timesery.
/// </summary>
public class Timesery
{
    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [JsonPropertyName("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the recipients clicks.
    /// </summary>
    [JsonPropertyName("recipients_clicks")]
    public int RecipientsClicks { get; set; }

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; }

    /// <summary>
    /// Gets or sets the unique opens.
    /// </summary>
    [JsonPropertyName("unique_opens")]
    public int UniqueOpens { get; set; }
}