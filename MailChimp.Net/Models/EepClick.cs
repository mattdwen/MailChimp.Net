﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EepClick.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The eep click.
/// </summary>
public class EepClick
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
    /// Gets or sets the locations.
    /// </summary>
    [JsonPropertyName("locations")]
    public IEnumerable<EepLocation> Locations { get; set; }
}