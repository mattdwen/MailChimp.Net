using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class StorePromoCodeResponse
{
    public StorePromoCodeResponse()
    {
        PromoCodes = new List<PromoCode>();
    }

    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("promo_codes")]
    public IList<PromoCode> PromoCodes { get; set; }
}
