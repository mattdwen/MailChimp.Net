// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Runtime.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The runtime.
/// </summary>
public class Runtime
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Runtime"/> class.
    /// </summary>
    public Runtime()
    {
        Days = new HashSet<string>();
    }

    /// <summary>
    /// Gets or sets the days.
    /// </summary>
    [JsonPropertyName("days")]
    public IEnumerable<string> Days { get; set; }

    /// <summary>
    /// Gets or sets the hours.
    /// </summary>
    [JsonPropertyName("hours")]
    public Hours Hours { get; set; }
}