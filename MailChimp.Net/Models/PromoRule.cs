using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Core;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class PromoRule
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("starts_at")]
    public DateTime? StartsAt { get; set; }

    [JsonPropertyName("ends_at")]
    public DateTime? EndsAt { get; set; }

    [JsonPropertyName("amount")]
    public decimal Amount { get; set; }
    
    [JsonPropertyName("type")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<PromoType>))]
    public PromoType Type { get; set; }

    [JsonPropertyName("target")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<PromoTarget>))]
    public PromoTarget Target { get; set; }

    [JsonPropertyName("enabled")]
    public bool Enabled { get; set; }
}

public enum PromoType
{
    [Description("fixed")]
    Fixed,
    [Description("percentage")]
    Percentage
}

public enum PromoTarget
{
    [Description("per_item")]
    PerItem,
    [Description("total")]
    Total,
    [Description("shipping")]
    Shipping
}
