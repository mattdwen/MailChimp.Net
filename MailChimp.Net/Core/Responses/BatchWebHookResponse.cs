using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class BatchWebHookResponse
{
    [JsonPropertyName("webhooks")]
    public IEnumerable<BatchWebHook> WebHooks { get; set; }
    [JsonPropertyName("url")]
    public string Url { get; set; }
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }
}
