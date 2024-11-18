// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Referrer.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The referrer.
/// </summary>
public class Referrer
{
    /// <summary>
    /// Gets or sets the clicks.
    /// </summary>
    [JsonPropertyName("clicks")]
    public int Clicks { get; set; }

    /// <summary>
    /// Gets or sets the first click.
    /// </summary>
    [JsonPropertyName("first_click")]
    public DateTime? FirstClick { get; set; }

    /// <summary>
    /// Gets or sets the last click.
    /// </summary>
    [JsonPropertyName("last_click")]
    public DateTime? LastClick { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("referrer")]
    public string Name { get; set; }
}