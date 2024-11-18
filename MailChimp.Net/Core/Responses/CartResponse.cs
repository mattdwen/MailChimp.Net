using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class CartResponse
{
    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("carts")]
    public IList<Cart> Carts { get; set; } = new List<Cart>();

    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    [JsonPropertyName("_links")]
    public IList<Link> Links { get; set; } = new List<Link>();
}
