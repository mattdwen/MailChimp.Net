using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class StorePromoRuleResponse : BaseResponse
{

    public StorePromoRuleResponse()
    {
        PromoRules = new List<PromoRule>();
    }

    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("promo_rules")]
    public IList<PromoRule> PromoRules { get; set; }
}
