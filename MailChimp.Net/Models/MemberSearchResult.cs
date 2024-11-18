using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MailChimp.Net.Models;


public class MemberSearchResult
{
    public MemberSearchResult()
    {
        Links = new HashSet<Link>();
    }

    [JsonPropertyName("exact_matches")]
    public ExactMatch ExactMatch { get; set; }

    [JsonPropertyName("full_search")]
    public FullSearch FullSearch { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }
}
