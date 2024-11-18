using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Promo
{
    [JsonPropertyName("code")]
    public string Code { get; set; }

    [JsonPropertyName("amount_discounted")]
    public decimal AmountDiscounted { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }
}