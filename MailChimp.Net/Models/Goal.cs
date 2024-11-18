// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Goal.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The goal.
/// </summary>
public class Goal
{
    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    [JsonPropertyName("data")]
    public string Data { get; set; }

    /// <summary>
    /// Gets or sets the event.
    /// </summary>
    [JsonPropertyName("event")]
    public string Event { get; set; }

    /// <summary>
    /// Gets or sets the goal id.
    /// </summary>
    [JsonPropertyName("goal_id")]
    public int GoalId { get; set; }

    /// <summary>
    /// Gets or sets the last visited at.
    /// </summary>
    [JsonPropertyName("last_visited_at")]
    public string LastVisitedAt { get; set; }
}