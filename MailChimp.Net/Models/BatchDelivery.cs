using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// Choose whether the campaign should use Batch Delivery. Cannot be set to <see langword="true"/> for campaigns using Timewarp.
/// </summary>
public class BatchDelivery
{
    /// <summary>
    /// The delay, in minutes, between batches.
    /// </summary>
    [JsonPropertyName("batch_delay")]
    public int Delay { get; set; }

    /// <summary>
    /// The number of batches for the campaign send.
    /// </summary>
    [JsonPropertyName("batch_count")]
    public int Count { get; set; }
}
