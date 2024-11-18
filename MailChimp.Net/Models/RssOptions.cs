using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class RssOptions
{
    [JsonPropertyName("feed_url")]
    public string Url { get; set; }
    [JsonPropertyName("frequency")]
    public string Frequency { get; set; }
    [JsonPropertyName("schedule")]
    public Schedule Schedule { get; set; }
    [JsonPropertyName("constrain_rss_img")]
    public bool ConstrainImage { get; set; }
}