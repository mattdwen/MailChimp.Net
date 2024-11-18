using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class SegmentCondition
{
    [JsonPropertyName("type")]
    public string Type { get; set; }
    [JsonPropertyName("operator")]
    public string Operator { get; set; }
    [JsonPropertyName("extra")]
    public string Extra { get; set; }
    [JsonPropertyName("field")]
    public string Field { get; set; }
    [JsonPropertyName("value")]
    public string Value { get; set; }
}
