// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The address.
/// </summary>
public class Address
{
    /// <summary>
    /// Gets or sets the address 1.
    /// </summary>
    [JsonPropertyName("address1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Gets or sets the address 2.
    /// </summary>
    [JsonPropertyName("address2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }

    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the postal code.
    /// </summary>
    [JsonPropertyName("postal_code")]
    public string PostalCode { get; set; }

    /// <summary>
    /// Gets or sets the province.
    /// </summary>
    [JsonPropertyName("province")]
    public string Province { get; set; }

    /// <summary>
    /// Gets or sets the province code.
    /// </summary>
    [JsonPropertyName("province_code")]
    public string ProvinceCode { get; set; }
}