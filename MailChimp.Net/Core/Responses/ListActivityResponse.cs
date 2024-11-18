using MailChimp.Net.Models;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MailChimp.Net.Core;

public class ListActivityResponse : BaseResponse
{
    public ListActivityResponse()
    {
        Activities = new List<ListActivity>();
    }
    [JsonPropertyName("activity")]
    public IEnumerable<ListActivity> Activities { get; set; }

    [JsonPropertyName("list_id")]
    public string ListId { get; set; }
}
