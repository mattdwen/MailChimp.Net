// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClientResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The client response.
/// </summary>
public class ClientResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientResponse"/> class.
    /// </summary>
    public ClientResponse()
    {
        Clients = new HashSet<Client>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the clients.
    /// </summary>
    [JsonPropertyName("clients")]
    public IEnumerable<Client> Clients { get; set; }

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