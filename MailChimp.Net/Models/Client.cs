// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Client.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The client.
/// </summary>
public class Client
{
    /// <summary>
    /// Gets or sets the client name.
    /// </summary>
    [JsonPropertyName("client")]
    public string ClientName { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the members.
    /// </summary>
    [JsonPropertyName("members")]
    public int Members { get; set; }
}