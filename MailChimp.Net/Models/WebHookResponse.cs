using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class WebHook
{

    public WebHook()
    {
        Links = new HashSet<Link>();
    }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("events")]
    public Event Event { get; set; }

    [JsonPropertyName("sources")]
    public Source Source { get; set; }

    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }
}
