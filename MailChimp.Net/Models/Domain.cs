// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Domain.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The domain.
/// </summary>
public class Domain
{
    /// <summary>
    /// Gets or sets the bounces.
    /// </summary>
    [JsonPropertyName("bounces")]
    public int Bounces { get; set; }

    /// <summary>
    /// Gets or sets the bounces pct.
    /// </summary>
    [JsonPropertyName("bounces_pct")]
    public int BouncesPct { get; set; }

    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonPropertyName("clicks")]
    public int Clicks { get; set; }

    /// <summary>
    /// Gets or sets the clicks pct.
    /// </summary>
    [JsonPropertyName("clicks_pct")]
    public int ClicksPct { get; set; }

    /// <summary>
    /// Gets or sets the delivered.
    /// </summary>
    [JsonPropertyName("delivered")]
    public int Delivered { get; set; }

    /// <summary>
    /// Gets or sets the domain name.
    /// </summary>
    [JsonPropertyName("domain")]
    public string DomainName { get; set; }

    /// <summary>
    /// Gets or sets the emails pct.
    /// </summary>
    [JsonPropertyName("emails_pct")]
    public int EmailsPct { get; set; }

    /// <summary>
    /// Gets or sets the emails sent.
    /// </summary>
    [JsonPropertyName("emails_sent")]
    public int EmailsSent { get; set; }

    /// <summary>
    /// Gets or sets the opens.
    /// </summary>
    [JsonPropertyName("opens")]
    public int Opens { get; set; }

    /// <summary>
    /// Gets or sets the opens pct.
    /// </summary>
    [JsonPropertyName("opens_pct")]
    public int OpensPct { get; set; }

    /// <summary>
    /// Gets or sets the unsubs.
    /// </summary>
    [JsonPropertyName("unsubs")]
    public int Unsubs { get; set; }

    /// <summary>
    /// Gets or sets the unsubs pct.
    /// </summary>
    [JsonPropertyName("unsubs_pct")]
    public int UnsubsPct { get; set; }
}