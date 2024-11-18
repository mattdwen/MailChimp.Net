// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Conversation.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The conversation.
/// </summary>
public class Conversation
{
    /// <summary>
    /// Gets or sets the campaign id.
    /// </summary>
    [JsonPropertyName("campaign_id")]
    public string CampaignId { get; set; }

    /// <summary>
    /// Gets or sets the from email.
    /// </summary>
    [JsonPropertyName("from_email")]
    public string FromEmail { get; set; }

    /// <summary>
    /// Gets or sets the from label.
    /// </summary>
    [JsonPropertyName("from_label")]
    public string FromLabel { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the last message.
    /// </summary>
    [JsonPropertyName("last_message")]
    public Message LastMessage { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the message count.
    /// </summary>
    [JsonPropertyName("message_count")]
    public int MessageCount { get; set; }

    /// <summary>
    /// Gets or sets the subject.
    /// </summary>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }

    /// <summary>
    /// Gets or sets the unread messages.
    /// </summary>
    [JsonPropertyName("unread_messages")]
    public int UnreadMessages { get; set; }
}