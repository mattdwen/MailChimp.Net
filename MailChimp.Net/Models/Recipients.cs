// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Recipients.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The recipient.
/// </summary>
public class Recipient
{
    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the segment text.
    /// </summary>
    [JsonPropertyName("segment_text")]
    public string SegmentText { get; set; }

    /// <summary>
		/// Gets or sets the segment options.
		/// </summary>
		[JsonPropertyName("segment_opts")]
    public SegmentOptions SegmentOptions { get; set; }
    
    /// <summary>
    /// Gets or sets the list name.
    /// </summary>
    [JsonPropertyName("list_name")]
    public string ListName { get; set; }
    
    /// <summary>
    /// Gets or sets the list is active flag.
    /// </summary>
    [JsonPropertyName("list_is_active")]
    public bool ListIsActive { get; set; }
    
    /// <summary>
    /// Gets or sets the recipient count.
    /// </summary>
    [JsonPropertyName("recipient_count")]
    public int RecipientCount { get; set; }
}
