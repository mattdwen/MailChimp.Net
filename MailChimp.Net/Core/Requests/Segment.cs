using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class Segment
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("static_segment")]
    public IEnumerable<string> EmailAddresses { get; set; }
    [JsonPropertyName("options")]
    public SegmentOptions Options { get; set; }
}
