using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class MemberStats
{
    [JsonPropertyName("avg_open_rate")]
    public double AverageOpenRate { get; set; }
    [JsonPropertyName("avg_click_rate")]
    public double AverageClickRate { get; set; }
}
