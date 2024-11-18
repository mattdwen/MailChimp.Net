using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class StoreCustomerResponse : BaseResponse
{

    public StoreCustomerResponse()
    {
        Customers = new List<Customer>();
    }

    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("customers")]
    public IList<Customer> Customers { get; set; }
}
