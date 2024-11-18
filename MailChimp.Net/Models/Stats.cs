// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stats.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The stats.
/// </summary>
public class Stats
{
    /// <summary>
    /// Gets or sets the avg sub rate.
    /// </summary>
    [JsonPropertyName("avg_sub_rate")]
    public double AvgSubRate { get; set; }

    /// <summary>
    /// Gets or sets the avg unsub rate.
    /// </summary>
    [JsonPropertyName("avg_unsub_rate")]
    public double AvgUnsubRate { get; set; }

    /// <summary>
    /// Gets or sets the campaign count.
    /// </summary>
    [JsonPropertyName("campaign_count")]
    public int CampaignCount { get; set; }

    /// <summary>
    /// Gets or sets the campaign last sent.
    /// </summary>
    [JsonPropertyName("campaign_last_sent")]
    public string CampaignLastSent { get; set; }

    /// <summary>
    /// Gets or sets the cleaned count.
    /// </summary>
    [JsonPropertyName("cleaned_count")]
    public int CleanedCount { get; set; }

    /// <summary>
    /// Gets or sets the cleaned count since send.
    /// </summary>
    [JsonPropertyName("cleaned_count_since_send")]
    public int CleanedCountSinceSend { get; set; }

    /// <summary>
    /// Gets or sets the click rate.
    /// </summary>
    [JsonPropertyName("click_rate")]
    public double ClickRate { get; set; }

    /// <summary>
    /// Gets or sets the last sub date.
    /// </summary>
    [JsonPropertyName("last_sub_date")]
    public string LastSubDate { get; set; }

    /// <summary>
    /// Gets or sets the last unsub date.
    /// </summary>
    [JsonPropertyName("last_unsub_date")]
    public string LastUnsubDate { get; set; }

    /// <summary>
    /// Gets or sets the member count.
    /// </summary>
    [JsonPropertyName("member_count")]
    public int MemberCount { get; set; }

    /// <summary>
    /// Gets or sets the member count since send.
    /// </summary>
    [JsonPropertyName("member_count_since_send")]
    public int MemberCountSinceSend { get; set; }

    /// <summary>
    /// Gets or sets the merge field count.
    /// </summary>
    [JsonPropertyName("merge_field_count")]
    public int MergeFieldCount { get; set; }

    /// <summary>
    /// Gets or sets the open rate.
    /// </summary>
    [JsonPropertyName("open_rate")]
    public double OpenRate { get; set; }

    /// <summary>
    /// Gets or sets the target sub rate.
    /// </summary>
    [JsonPropertyName("target_sub_rate")]
    public double TargetSubRate { get; set; }

    /// <summary>
    /// Gets or sets the unsubscribe count.
    /// </summary>
    [JsonPropertyName("unsubscribe_count")]
    public int UnsubscribeCount { get; set; }

    /// <summary>
    /// Gets or sets the unsubscribe count since send.
    /// </summary>
    [JsonPropertyName("unsubscribe_count_since_send")]
    public int UnsubscribeCountSinceSend { get; set; }
}