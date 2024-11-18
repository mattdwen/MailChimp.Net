using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Result
{
    [JsonPropertyName("campaign")]
    public Campaign Campaign { get; set; }

    [JsonPropertyName("snippet")]
    public string Snippet { get; set; }
}
