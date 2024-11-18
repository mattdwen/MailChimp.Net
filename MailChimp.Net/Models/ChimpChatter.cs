using System;
using MailChimp.Net.Core;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// Represents a single chimp chatter activity
/// </summary>
public class ChimpChatter
{

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("message")]
    public string Message { get; set; }

    [JsonPropertyName("type")]
	[JsonConverter(typeof(StringEnumDescriptionConverter<ChimpChatterType>))]
    public ChimpChatterType Type { get; set; }

    [JsonPropertyName("update_time")]
    public DateTime UpdateTime { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

}
