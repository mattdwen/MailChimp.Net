using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class ListEvent
{
    /// <summary>
    /// The name for this type of event ('purchased', 'visited', etc). Must be 2-30 characters in length
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The date and time the event occurred in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("occurred_at")]
    public DateTime? OccurredAt { get; set; }

    /// <summary>
    /// Events created with the is_syncing value set to true will not trigger automations.
    /// </summary>
    [JsonPropertyName("is_syncing")]
    public bool? IsSyncing { get; set; }

    /// <summary>
    /// An optional list of properties
    /// </summary>
    [JsonPropertyName("properties")]
    public IDictionary<string, object> Properties { get; set; }
}
