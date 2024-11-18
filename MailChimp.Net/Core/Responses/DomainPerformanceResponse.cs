// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DomainPerformanceResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The domain performance response.
/// </summary>
public class DomainPerformanceResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DomainPerformanceResponse"/> class.
    /// </summary>
    public DomainPerformanceResponse()
    {
        Domains = new HashSet<Domain>();
    }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the domains.
    /// </summary>
    [JsonPropertyName("domains")]
    public IEnumerable<Domain> Domains { get; set; }

    /// <summary>
    /// Gets or sets the total sent.
    /// </summary>
    [JsonPropertyName("total_sent")]
    public int TotalSent { get; set; }
}