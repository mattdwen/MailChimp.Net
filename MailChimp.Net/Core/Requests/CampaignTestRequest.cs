// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignTestRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The content request.
/// </summary>
public class CampaignTestRequest
{

    /// <summary>
    /// Gets or sets the array of test email addresses
    /// </summary>
    [JsonPropertyName("test_emails")]
    public string[] Emails { get; set; }

    /// <summary>
    /// Email type 'html' or 'plain_test'
    /// </summary>
    [JsonPropertyName("send_type")]
    public string EmailType { get; set; }

}