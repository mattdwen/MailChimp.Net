using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class MailChimpApiError
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("status")]
    public int Status { get; set; }
    [JsonPropertyName("detail")]
    public string Detail { get; set; }
    [JsonPropertyName("instance")]
    public string Instance { get; set; }
    [JsonPropertyName("errors")]
    public List<MailChimpError> Errors { get; set; } = new List<MailChimpError>();
}

public class MailChimpError
{
    [JsonPropertyName("field")]
    public string Field { get; set; }
    [JsonPropertyName("message")]
    public string Message { get; set; }
}
