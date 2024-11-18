using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class ListSegmentResponse
{

    public ListSegmentResponse()
    {
        Segments = new HashSet<ListSegment>();
        Links = new HashSet<Link>();
    }

    [JsonPropertyName("segments")]
    public IEnumerable<ListSegment> Segments { get; set; }

    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }
}
