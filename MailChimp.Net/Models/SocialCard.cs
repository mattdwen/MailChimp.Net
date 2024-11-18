using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class SocialCard
{
    [JsonPropertyName("image_url")]
    public string ImageUrl { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }
}