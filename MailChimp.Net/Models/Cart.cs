using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

public class Cart
{
    public Cart()
    {
        Lines = new HashSet<Line>();
        Links = new HashSet<Link>();
    }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("customer")]
    public Customer Customer { get; set; }

    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    [JsonPropertyName("checkout_url")]
    public string CheckoutUrl { get; set; }

    [JsonPropertyName("currency_code")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<CurrencyCode>))]
    public CurrencyCode CurrencyCode { get; set; }

    [JsonPropertyName("order_total")]
    public decimal? OrderTotal { get; set; }

    [JsonPropertyName("tax_total")]
    public decimal? TaxTotal { get; set; }

    [JsonPropertyName("lines")]
    public ICollection<Line> Lines { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("_links")]
    public ICollection<Link> Links { get; set; }
}
