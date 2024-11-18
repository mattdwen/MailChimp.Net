// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GrowthHistoryResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The growth history response.
/// </summary>
public class GrowthHistoryResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GrowthHistoryResponse"/> class.
    /// </summary>
    public GrowthHistoryResponse()
    {
        History = new HashSet<History>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the history.
    /// </summary>
    [JsonPropertyName("history")]
    public IEnumerable<History> History { get; set; }

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