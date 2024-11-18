// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiInfo.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The contact.
/// </summary>
public class ApiContact
{
    /// <summary>
    /// Gets or sets the company.
    /// </summary>
    [JsonPropertyName("company")]
    public string Company { get; set; }

    /// <summary>
    /// Gets or sets the address 1.
    /// </summary>
    [JsonPropertyName("addr1")]
    public string Address1 { get; set; }

    /// <summary>
    /// Gets or sets the address 2.
    /// </summary>
    [JsonPropertyName("addr2")]
    public string Address2 { get; set; }

    /// <summary>
    /// Gets or sets the city.
    /// </summary>
    [JsonPropertyName("city")]
    public string City { get; set; }

    /// <summary>
    /// Gets or sets the state.
    /// </summary>
    [JsonPropertyName("state")]
    public string State { get; set; }

    /// <summary>
    /// Gets or sets the zip.
    /// </summary>
    [JsonPropertyName("zip")]
    public string Zip { get; set; }

    /// <summary>
    /// Gets or sets the country.
    /// </summary>
    [JsonPropertyName("country")]
    public string Country { get; set; }
}
