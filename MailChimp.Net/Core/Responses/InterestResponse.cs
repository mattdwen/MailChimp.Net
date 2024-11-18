// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InterestResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The interest response.
/// </summary>
public class InterestResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InterestResponse"/> class.
    /// </summary>
    public InterestResponse()
    {
        Links = new HashSet<Link>();
        Interests = new HashSet<Interest>();
    }

    /// <summary>
    /// Gets or sets the category id.
    /// </summary>
    [JsonPropertyName("category_id")]
    public string CategoryId { get; set; }

    /// <summary>
    /// Gets or sets the interests.
    /// </summary>
    [JsonPropertyName("interests")]
    public IEnumerable<Interest> Interests { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the total items.
    /// </summary>
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }
}