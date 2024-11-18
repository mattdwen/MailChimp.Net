// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClickReportMemberResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The click report member response.
/// </summary>
public class ClickReportMemberResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClickReportMemberResponse"/> class.
    /// </summary>
    public ClickReportMemberResponse()
    {
        Members = new HashSet<ClickMember>();
        Links = new HashSet<Link>();
    }

    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the members.
    /// </summary>
    [JsonPropertyName("members")]
    public IEnumerable<ClickMember> Members { get; set; }
}