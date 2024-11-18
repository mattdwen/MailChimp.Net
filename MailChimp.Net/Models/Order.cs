using System.Collections.Generic;
using System.Text.Json.Serialization;
using MailChimp.Net.Core;
using System;

namespace MailChimp.Net.Models;

public class Order
{

    public Order()
    {
        Lines = new List<Line>();
        Links = new List<Link>();
        Promos = new List<Promo>();
    }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("customer")]
    public Customer Customer { get; set; }

    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    [JsonPropertyName("landing_site")]
    public string LandingSite { get; set; }

    [JsonPropertyName("financial_status")]
    public string FinancialStatus { get; set; }

    [JsonPropertyName("fulfillment_status")]
    public string FulfillmentStatus { get; set; }

    [JsonPropertyName("currency_code")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<CurrencyCode>))]
    public CurrencyCode CurrencyCode { get; set; }

    [JsonPropertyName("order_total")]
    public decimal OrderTotal { get; set; }

    [JsonPropertyName("order_url")]
    public string OrderUrl { get; set; }

    [JsonPropertyName("discount_total")]
    public decimal? DiscountTotal { get; set; }

    [JsonPropertyName("tax_total")]
    public decimal? TaxTotal { get; set; }

    [JsonPropertyName("shipping_total")]
    public decimal? ShippingTotal { get; set; }

    [JsonPropertyName("tracking_code")]
    public string TrackingCode { get; set; }

    [JsonPropertyName("processed_at_foreign")]
    public string ProcessedAtForeign { get; set; }

    [JsonPropertyName("cancelled_at_foreign")]
    public string CancelledAtForeign { get; set; }

    [JsonPropertyName("shipping_address")]
    public OrderAddress ShippingAddress { get; set; }

    [JsonPropertyName("billing_address")]
    public OrderAddress BillingAddress { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }

    [JsonPropertyName("updated_at_foreign")]
    public DateTime? UpdatedAtForeign { get; set; }

    [JsonPropertyName("promos")]
    public IList<Promo> Promos { get; set; }

    [JsonPropertyName("lines")]
    public IList<Line> Lines { get; set; }
    
    [JsonPropertyName("outreach")]
    public Outreach Outreach { get; set; }

    [JsonPropertyName("_links")]
    public IList<Link> Links { get; set; }
}
