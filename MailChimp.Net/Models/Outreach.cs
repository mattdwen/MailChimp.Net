using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Outreach
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
}