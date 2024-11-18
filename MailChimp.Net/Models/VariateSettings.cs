using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class VariateSettings
{
    [JsonPropertyName("winning_combination_id")]
    public string WinningCombinationId { get; set; }

    [JsonPropertyName("winning_campaign_id")]
    public string WinningCampaignId { get; set; }
    [JsonPropertyName("winner_criteria")]
    public string WinnerCriteria { get; set; }
    [JsonPropertyName("combinations")]
    public IEnumerable<Combination> Combinations { get; set; }
}
