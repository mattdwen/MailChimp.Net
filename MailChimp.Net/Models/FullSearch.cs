using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MailChimp.Net.Models;

public class FullSearch
{
    public FullSearch()
    {
        Members = new HashSet<Member>();
    }

    [JsonPropertyName("members")]
    public IEnumerable<Member> Members { get; set; }

    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }
}
