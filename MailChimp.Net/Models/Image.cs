using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Image
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("variant_ids")]
    public IList<string> VariantIds { get; set; }

    [JsonPropertyName("_links")]
    public IList<Link> Links { get; set; }
}