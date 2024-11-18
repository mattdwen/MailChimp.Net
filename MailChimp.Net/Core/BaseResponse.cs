// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The base response.
/// </summary>
public abstract class BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BaseResponse"/> class.
    /// </summary>
    protected BaseResponse()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the total items.
    /// </summary>
    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }
}