using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core.Responses;

public class BatchListResponse
{
    /// <summary>
    /// An array of objects, each representing a new member that was added to the list.
    /// </summary>
    [JsonPropertyName("new_members")]
    public List<NewMember> NewMembers { get; set; }

    /// <summary>
    /// An array of objects, each representing an existing list member whose subscription status was updated.
    /// </summary>
    [JsonPropertyName("updated_members")]
    public List<NewMember> UpdatedMembers { get; set; }

    /// <summary>
    /// An array of objects, each representing an email address that could not be added to the list
    /// or updated and an error message providing more details.
    /// </summary>
    [JsonPropertyName("errors")]
    public List<ErrorResponse> Errors { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("total_created")]
    public int TotalCreated { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("total_updated")]
    public int TotalUpdated { get; set; }

    /// <summary>
    /// The total number of items matching the query, irrespective of pagination.
    /// </summary>
    [JsonPropertyName("error_count")]
    public int ErrorCount { get; set; }

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonPropertyName("_links")]
    public List<Link> Links { get; set; }
}