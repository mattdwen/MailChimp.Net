// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Store.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;

using System.Text.Json.Serialization;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The store.
/// </summary>
public class Store
{
    public Store()
    {
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the address.
    /// </summary>
    [JsonPropertyName("address")]
    public StoreAddress Address { get; set; }

    /// <summary>
    /// Gets or sets the created at.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or sets the currency code.
    /// </summary>
    [JsonPropertyName("currency_code")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<CurrencyCode>))]
    public CurrencyCode CurrencyCode { get; set; }

    /// <summary>
    /// Gets or sets the platform.
    /// </summary>
    [JsonPropertyName("platform")]
    public string Platform { get; set; }


    /// <summary>
    /// Gets or sets the syncing flag.
    /// </summary>
    [JsonPropertyName("is_syncing")]
    public bool IsSyncing { get; set; }

    /// <summary>
    /// Gets or sets the domain.
    /// </summary>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// The unique identifier for the store.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// The unique identifier for the <a href="http://developer.mailchimp.com/documentation/mailchimp/reference/lists/">MailChimp List</a> associated with the store. The list_id for a specific store cannot change.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the money format.
    /// For example: $, £, etc.
    /// </summary>
    [JsonPropertyName("money_format")]
    public string MoneyFormat { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// The store phone number.
    /// </summary>
    [JsonPropertyName("phone")]
    public string Phone { get; set; }

    /// <summary>
    /// Gets or sets the primary locale.
    /// For example: en, de, etc.
    /// </summary>
    [JsonPropertyName("primary_locale")]
    public string PrimaryLocale { get; set; }

    /// <summary>
    /// The timezone for the store.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string Timezone { get; set; }

    /// <summary>
    /// Gets or sets the updated at.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}