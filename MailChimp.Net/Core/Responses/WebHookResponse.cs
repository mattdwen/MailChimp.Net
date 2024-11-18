using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class WebHookResponse : BaseResponse
{

    public WebHookResponse()
    {
        Webhooks = new HashSet<WebHook>();
    }

    [JsonPropertyName("webhooks")]
    public IEnumerable<WebHook> Webhooks { get; set; }

    [JsonPropertyName("list_id")]
    public string ListId { get; set; }
}

