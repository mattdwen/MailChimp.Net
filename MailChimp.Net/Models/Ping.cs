// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The ping response
/// </summary>
public class Ping
{      

    /// <summary>
    /// Gets the health status from Mail Chimp
    /// </summary>
    [JsonPropertyName("health_status")]
    public string HealthStatus { get; set; }
}