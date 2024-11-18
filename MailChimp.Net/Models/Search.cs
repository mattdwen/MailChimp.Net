using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MailChimp.Net.Models;

public class CampaignSearchResult
{
    public CampaignSearchResult()
    {
        Results = new List<Result>();
        Links = new List<Link>();
    }

    [JsonPropertyName("results")]
    public IEnumerable<Result> Results { get; set; }

    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }
}
