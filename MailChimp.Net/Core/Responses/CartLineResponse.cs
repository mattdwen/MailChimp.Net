using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class CartLineResponse
{

    public CartLineResponse()
    {
        Lines = new List<Line>();
        Links = new List<Link>();
    }

    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("cart_id")]
    public string CartId { get; set; }

    [JsonPropertyName("lines")]
    public ICollection<Line> Lines { get; set; }

    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    [JsonPropertyName("_links")]
    public ICollection<Link> Links { get; set; }
}
