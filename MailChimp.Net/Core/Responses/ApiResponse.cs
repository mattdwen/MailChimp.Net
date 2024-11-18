// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The api response.
/// </summary>
public class ApiResponse
{
    /// <summary>
    /// Gets or sets the account id.
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }

    /// <summary>
    /// Gets or sets the account name.
    /// </summary>
    [JsonPropertyName("account_name")]
    public string AccountName { get; set; }

    /// <summary>
    /// Gets or sets the contact.
    /// </summary>
    [JsonPropertyName("contact")]
    public Contact Contact { get; set; }

    /// <summary>
    /// Gets or sets the last login.
    /// </summary>
    [JsonPropertyName("last_login")]
    public string LastLogin { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the total subscribers.
    /// </summary>
    [JsonPropertyName("total_subscribers")]
    public int TotalSubscribers { get; set; }
}