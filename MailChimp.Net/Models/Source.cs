using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Source
{
    [JsonPropertyName("user")]
    public bool User { get; set; }

    [JsonPropertyName("admin")]
    public bool Admin { get; set; }

    [JsonPropertyName("api")]
    public bool Api { get; set; }
}
