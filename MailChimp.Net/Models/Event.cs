using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Event
{
    [JsonPropertyName("subscribe")]
    public bool Subscribe { get; set; }

    [JsonPropertyName("unsubscribe")]
    public bool Unsubscribe { get; set; }

    [JsonPropertyName("profile")]
    public bool Profile { get; set; }

    [JsonPropertyName("cleaned")]
    public bool Cleaned { get; set; }

    [JsonPropertyName("upemail")]
    public bool Upemail { get; set; }

    [JsonPropertyName("campaign")]
    public bool Campaign { get; set; }
}
