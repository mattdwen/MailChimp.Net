﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutomationSubscriberResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The automation subscriber response.
/// </summary>
public class AutomationSubscriberResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutomationSubscriberResponse"/> class.
    /// </summary>
    public AutomationSubscriberResponse()
    {
        Subscribers = new HashSet<Subscriber>();
    }

    /// <summary>
    /// Gets or sets the subscribers.
    /// </summary>
    [JsonPropertyName("subscribers")]
    public IEnumerable<Subscriber> Subscribers { get; set; }

    /// <summary>
    /// Gets or sets the total items.
    /// </summary>
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    /// <summary>
    /// Gets or sets the workflow id.
    /// </summary>
    [JsonPropertyName("workflow_id")]
    public string WorkflowId { get; set; }
}