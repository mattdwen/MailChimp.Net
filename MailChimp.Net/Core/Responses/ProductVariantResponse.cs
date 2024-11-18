using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class ProductVariantResponse : BaseResponse
{

    public ProductVariantResponse()
    {
        Variants = new List<Variant>();
    }

    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("product_id")]
    public string ProductId { get; set; }

    [JsonPropertyName("variants")]
    public IList<Variant> Variants { get; set; }
}
