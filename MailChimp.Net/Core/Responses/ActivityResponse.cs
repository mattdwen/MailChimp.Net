﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActivityResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The activity response.
/// </summary>
public class ActivityResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ActivityResponse"/> class.
    /// </summary>
    public ActivityResponse()
    {
        Activities = new HashSet<Activity>();
    }

    /// <summary>
    /// Gets or sets the activities.
    /// </summary>
    [JsonPropertyName("activity")]
    public IEnumerable<Activity> Activities { get; set; }

    /// <summary>
    /// Gets or sets the email id.
    /// </summary>
    [JsonPropertyName("email_id")]
    public string EmailId { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }
}