using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class BatchList
{
    /// <summary>
    /// An array of objects, each representing an email address and the subscription status for a specific list.
    /// Up to 500 members may be added or updated with each API call.
    /// </summary>
    [JsonPropertyName("members")]
    public IEnumerable<Member> Members { get; set; }

    /// <summary>
    /// Whether this batch operation will change existing members’ subscription status.
    /// </summary>
    [JsonPropertyName("update_existing")]
    public bool UpdateExisting { get; set; }
}