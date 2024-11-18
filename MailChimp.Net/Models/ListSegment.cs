using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class ListSegment
{
    public ListSegment()
    {
        Links = new HashSet<Link>();
    }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("member_count")]
    public int MemberCount { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    [JsonPropertyName("options")]
    public SegmentOptions Options { get; set; }
}
