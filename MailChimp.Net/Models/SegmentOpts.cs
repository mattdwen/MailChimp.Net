// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SegmentOpts.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MailChimp.Net.Core;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The segment opts.
/// </summary>
public class SegmentOptions
{

    public SegmentOptions()
    {
        Conditions = new HashSet<Condition>();
    }

    /// <summary>
    /// Gets or sets the conditions.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<Condition> Conditions { get; set; }

    /// <summary>
    /// Gets or sets the match.
    /// </summary>
    /// <see cref="Models.Match"/>
    [JsonPropertyName("match")]
	[JsonConverter(typeof(StringEnumDescriptionConverter<Match>))]
    public Match Match { get; set; }

    /// <summary>
    /// Gets or sets the saved segment id.
    /// </summary>
    [JsonPropertyName("saved_segment_id")]
    public int SavedSegmentId { get; set; }
}