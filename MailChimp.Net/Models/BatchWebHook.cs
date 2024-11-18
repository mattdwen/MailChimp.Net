using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class BatchWebHook
{

    public string Id { get; set; }
    public string Url { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

}
