// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TimeStamp.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

using System;

namespace MailChimp.Net.Models;

/// <summary>
/// The TimeStamp.
/// </summary>
public class TimeStamp
{

    /// <summary>
    /// Gets or sets the Timestamp.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public DateTime Timestamp { get; set; }

}
