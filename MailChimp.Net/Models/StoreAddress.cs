using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// Store address.
/// </summary>
public class StoreAddress : Address
{
    /// <summary>
    /// Gets or sets the latitude.
    /// </summary>
    [JsonPropertyName("latitude")]
    public decimal? Latitude { get; set; }

    /// <summary>
    /// Gets or sets the longitude.
    /// </summary>
    [JsonPropertyName("longitude")]
    public decimal? Longitude { get; set; }

}