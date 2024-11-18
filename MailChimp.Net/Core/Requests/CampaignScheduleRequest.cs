// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CampaignTestRequest.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The content request.
/// </summary>
public class CampaignScheduleRequest
{

    /// <summary>
    /// Gets or sets the schedule_time property in UTC  format
    /// </summary>
    [JsonPropertyName("schedule_time")]
    public string ScheduleTime { get; set; }

    /// <summary>
    /// Gets or sets 'timewarp' to send emails at localized time
    /// </summary>
    [JsonPropertyName("timewarp")]
    public bool? Timewarp { get; set; }

    /// <summary>
    /// Choose whether the campaign should use Batch Delivery. Cannot be set to <see langword="true"/> for campaigns using Timewarp. 
    /// </summary>
    [JsonPropertyName("batch_delivery")]
    public BatchDelivery BatchDelivery { get; set; }
}