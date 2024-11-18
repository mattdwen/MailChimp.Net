// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClickReportResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The click report response.
/// </summary>
public class ClickReportResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickReportResponse"/> class.
    /// </summary>
    public ClickReportResponse()
    {
        UrlsClicked = new HashSet<UrlClicked>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the urls clicked.
    /// </summary>
    [JsonPropertyName("urls_clicked")]
    public IEnumerable<UrlClicked> UrlsClicked { get; set; }
}