// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OpenLocation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The open location.
/// </summary>
public class OpenLocation
{
    /// <summary>
    /// Gets or sets the country code.
    /// </summary>
    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [JsonPropertyName("opens")]
    public int Opens { get; set; }

    /// <summary>
    /// Gets or sets the region.
    /// </summary>
    [JsonPropertyName("region")]
    public string Region { get; set; }
}