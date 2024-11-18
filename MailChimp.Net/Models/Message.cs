// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Message.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The message.
/// </summary>
public class Message
{
    /// <summary>
    /// Gets or sets the body.
    /// </summary>
    [JsonPropertyName("message")]
    public string Body { get; set; }

    /// <summary>
    /// Gets or sets the from email.
    /// </summary>
    [JsonPropertyName("from_email")]
    public string FromEmail { get; set; }

    /// <summary>
    /// Gets or sets the from label.
    /// </summary>
    [JsonPropertyName("from_label")]
    public string FromLabel { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether read.
    /// </summary>
    [JsonPropertyName("read")]
    public bool Read { get; set; }

    /// <summary>
    /// Gets or sets the subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Gets or sets the timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; }
}