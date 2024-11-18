// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AbuseReportResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json.Serialization;
using MailChimp.Net.Models;

namespace MailChimp.Net.Core;

/// <summary>
/// The abuse report response.
/// </summary>
public class AbuseReportResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AbuseReportResponse"/> class.
    /// </summary>
    public AbuseReportResponse()
    {
        AbuseReports = new HashSet<AbuseReport>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the abuse reports.
    /// </summary>
    [JsonPropertyName("abuse_reports")]
    public IEnumerable<AbuseReport> AbuseReports { get; set; }
    

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }
    
}