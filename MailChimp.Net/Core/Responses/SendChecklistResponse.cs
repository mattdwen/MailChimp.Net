// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SendChecklistResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The send checklist response.
/// </summary>
public class SendChecklistResponse : BaseResponse
{
    /// <summary>
    /// Gets or sets the check lists.
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<CheckList> CheckLists { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether is ready.
    /// </summary>
    [JsonPropertyName("is_ready")]
    public bool IsReady { get; set; }
}