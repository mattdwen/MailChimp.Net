﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EmailResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The email response.
/// </summary>
public class EmailResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailResponse"/> class.
    /// </summary>
    public EmailResponse()
    {
        EmailActivities = new HashSet<EmailActivity>();
    }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the email activities.
    /// </summary>
    [JsonPropertyName("emails")]
    public IEnumerable<EmailActivity> EmailActivities { get; set; }
}