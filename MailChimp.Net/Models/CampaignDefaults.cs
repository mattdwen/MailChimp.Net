// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignDefaults.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The campaign defaults.
/// </summary>
public class CampaignDefaults
{
    /// <summary>
    /// Gets or sets the from email.
    /// </summary>
    [JsonPropertyName("from_email")]
    public string FromEmail { get; set; }

    /// <summary>
    /// Gets or sets the from name.
    /// </summary>
    [JsonPropertyName("from_name")]
    public string FromName { get; set; }

    /// <summary>
    /// Gets or sets the language.
    /// </summary>
    [JsonPropertyName("language")]
    public string Language { get; set; }

    /// <summary>
    /// Gets or sets the subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }
}