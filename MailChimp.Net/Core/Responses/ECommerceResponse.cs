using MailChimp.Net.Models;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MailChimp.Net.Core;

public class ECommerceResponse : BaseResponse
{

    [JsonPropertyName("stores")]
    public IEnumerable<Store> Stores { get; set; }
}
