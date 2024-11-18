using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class EmailMemberActivity
{
    [JsonPropertyName("action")]
    public string Action { get; set; }

    [JsonPropertyName("timestamp")]
    public string Timestamp { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("ip")]
    public string Ip { get; set; }
}
