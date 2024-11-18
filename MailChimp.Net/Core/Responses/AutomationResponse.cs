// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AutomationResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The automation response.
/// </summary>
public class AutomationResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AutomationResponse"/> class.
    /// </summary>
    public AutomationResponse()
    {
        Automations = new HashSet<Automation>();
    }

    /// <summary>
    /// Gets or sets the automations.
    /// </summary>
    [JsonPropertyName("automations")]
    public IEnumerable<Automation> Automations { get; set; }
}