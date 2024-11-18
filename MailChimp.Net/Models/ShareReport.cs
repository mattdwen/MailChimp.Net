// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShareReport.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The share report.
/// </summary>
public class ShareReport
{
    /// <summary>
    /// Gets or sets the share password.
    /// </summary>
    [JsonPropertyName("share_password")]
    public string SharePassword { get; set; }

    /// <summary>
    /// Gets or sets the share url.
    /// </summary>
    [JsonPropertyName("share_url")]
    public string ShareUrl { get; set; }
}