using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The batch segment members response.
/// </summary>
public class BatchSegmentMembersResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BatchSegmentMembers"/> class.
    /// </summary>
    public BatchSegmentMembersResponse()
    {
        MembersAdded = new Member[0];
        MembersRemoved = new Member[0];
    }

    /// <summary>
    /// Members added
    /// </summary>
    [JsonPropertyName("members_added")]
    public Member[] MembersAdded { get; set; }

    /// <summary>
    /// Members removed
    /// </summary>
    [JsonPropertyName("members_removed")]
    public Member[] MembersRemoved { get; set; }

    [JsonPropertyName("total_added")]
    public int TotalAdded { get; set; }

    [JsonPropertyName("total_removed")]
    public int TotalRemoved { get; set; }

    [JsonPropertyName("error_count")]
    public int ErrorCount { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }
}
