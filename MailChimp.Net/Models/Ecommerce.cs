using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Ecommerce
{

    [JsonPropertyName("total_orders")]
    public int TotalOrders { get; set; }

    [JsonPropertyName("total_spent")]
    public decimal TotalSpent { get; set; }

    [JsonPropertyName("total_revenue")]
    public decimal TotalRevenue { get; set; }
}
