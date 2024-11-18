// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Feedback.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using MailChimp.Net.Core;
using System.Text.Json.Serialization;
using System;

// ReSharper disable UnusedAutoPropertyAccessor.Local
namespace MailChimp.Net.Models;

/// <summary>
/// The feedback.
/// </summary>
public class Feedback
{
    /// <summary>
    /// Gets or sets the block id.
    /// </summary>
    [JsonPropertyName("block_id")]
    public int BlockId { get; set; }

    /// <summary>
    /// Gets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets the created at.
    /// </summary>
    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets the created by.
    /// </summary>
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets the feedback id.
    /// </summary>
    [JsonPropertyName("feedback_id")]
    public int? FeedbackId { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether is complete.
    /// </summary>
    [JsonPropertyName("is_complete")]
    public bool IsComplete { get; set; }

    /// <summary>
    /// Gets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the message.
    /// </summary>
    [JsonPropertyName("message")]
    public string Message { get; set; }

    /// <summary>
    /// Gets the parent id.
    /// </summary>
    [JsonPropertyName("parent_id")]
    public int ParentId { get; set; }

    /// <summary>
    /// Gets the source.
    /// </summary>
    [JsonPropertyName("source")]
	[JsonConverter(typeof(StringEnumDescriptionConverter<FeedbackSource>))]
    public FeedbackSource Source { get; set; }

    /// <summary>
    /// Gets the updated at.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public DateTime? UpdatedAt { get; set; }
}