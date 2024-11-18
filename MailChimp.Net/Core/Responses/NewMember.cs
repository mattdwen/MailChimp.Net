using System;
using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core.Responses;

public class NewMember
{
    /// <summary>
    /// The MD5 hash of the lowercase version of the list member’s email address.
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Email address for a subscriber.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// An identifier for the address across all of Mailchimp.
    /// </summary>
    [JsonPropertyName("unique_email_id")]
    public string UniqueEmailId { get; set; }

    /// <summary>
    /// Type of email this member asked to get (‘html’ or ‘text’).
    /// </summary>
    [JsonPropertyName("email_type")]
    public string EmailType { get; set; }

    /// <summary>
    /// Subscriber’s current status.
    /// </summary>
    /// <value>Possible Values: subscribed / unsubscribed / cleaned / pending / transactional</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }

    /// <summary>
    /// An individual merge var and value for a member.
    /// </summary>
    [JsonPropertyName("merge_fields")]
    public MergeFields MergeFields { get; set; }

    /// <summary>
    /// Open and click rates for this subscriber.
    /// </summary>
    [JsonPropertyName("stats")]
    public Stats Stats { get; set; }

    /// <summary>
    /// IP address the subscriber signed up from.
    /// </summary>
    [JsonPropertyName("ip_signup")]
    public string IpSignup { get; set; }

    /// <summary>
    /// The date and time the subscriber signed up for the list in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("timestamp_signup")]
    public string TimestampSignup { get; set; }

    /// <summary>
    /// The IP address the subscriber used to confirm their opt-in status.
    /// </summary>
    [JsonPropertyName("ip_opt")]
    public string IpOpt { get; set; }

    /// <summary>
    /// The date and time the subscriber confirmed their opt-in status in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("timestamp_opt")]
    public DateTime? TimestampOpt { get; set; }

    /// <summary>
    /// Star rating for this member, between 1 and 5.
    /// </summary>
    [JsonPropertyName("member_rating")]
    public int MemberRating { get; set; }

    /// <summary>
    /// The date and time the member’s info was last changed in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("last_changed")]
    public DateTime? LastChanged { get; set; }

    /// <summary>
    /// If set/detected, the subscriber’s language.
    /// </summary>
    [JsonPropertyName("language")]
    public string Language { get; set; }

    /// <summary>
    /// VIP status for subscriber.
    /// </summary>
    [JsonPropertyName("vip")]
    public bool Vip { get; set; }

    /// <summary>
    /// The list member’s email client.
    /// </summary>
    [JsonPropertyName("email_client")]
    public string EmailClient { get; set; }

    /// <summary>
    /// Subscriber location information.
    /// </summary>
    [JsonPropertyName("location")]
    public Location Location { get; set; }

    /// <summary>
    /// The number of tags applied to this member.
    /// </summary>
    [JsonPropertyName("tags_count")]
    public int TagsCount { get; set; }

    /// <summary>
    /// The tags applied to this member.
    /// </summary>
    [JsonPropertyName("tags")]
    public List<object> Tags { get; set; }

    /// <summary>
    /// The list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// A list of link types and descriptions for the API schema documents.
    /// </summary>
    [JsonPropertyName("_links")]
    public List<Link> Links { get; set; }
}