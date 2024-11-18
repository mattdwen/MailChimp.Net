using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class StoreOrderResponse : BaseResponse
{

    public StoreOrderResponse()
    {
        Orders = new List<Order>();
    }

    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("orders")]
    public IList<Order> Orders { get; set; }
}
