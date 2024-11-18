using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class StoreProductResponse : BaseResponse
{

    public StoreProductResponse()
    {
        Products = new List<Product>();
    }
    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("products")]
    public IList<Product> Products { get; set; }
}
