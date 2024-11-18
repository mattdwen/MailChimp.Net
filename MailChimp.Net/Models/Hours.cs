// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Hours.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The hours.
/// </summary>
public class Hours
{
    /// <summary>
    /// Gets or sets the send at.
    /// </summary>
    [JsonPropertyName("send_at")]
    public string SendAt { get; set; }
}