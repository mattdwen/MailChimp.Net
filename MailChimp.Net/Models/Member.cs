// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Member.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using MailChimp.Net.Core;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

	/// <summary>
	/// The member.
	/// </summary>
	public class Member
	{
		public Member()
		{
			MergeFields = new Dictionary<string, object>();
			MarketingPermissions = new List<MarketingPermission>();
			Links = new List<Link>();
			Interests = new Dictionary<string, bool>();
			Status = Status.Undefined;
			StatusIfNew = Status.Pending;
			Tags = new List<MemberTag>();
		}

    /// <summary>
    /// Gets or sets the email address.
    /// </summary>
    [JsonPropertyName("email_address")]
    public string EmailAddress { get; set; }

    /// <summary>
    /// Source of the member
    /// </summary>
    [JsonPropertyName("source")]
    public string Source { get; set; }

    /// <summary>
    /// The full name of the member
    /// </summary>
    [JsonPropertyName("full_name")]
    public string FullName { get; set; }

    /// <summary>
    /// Gets or sets the contact id
    /// </summary>
    [JsonPropertyName("contact_id")]
    public string ContactId { get; set; }

    /// <summary>
    /// Gets or sets the email client.
    /// </summary>
    [JsonPropertyName("email_client")]
		public string EmailClient { get; set; }

    /// <summary>
    /// Gets or sets the email type.
    /// </summary>
    [JsonPropertyName("email_type")]
    public string EmailType { get; set; }

    /// <summary>
    /// Gets or sets the constents flag
    /// </summary>
    [JsonPropertyName("consents_to_one_to_one_messaging")]
    public bool ConsentsToOneToOneMessaging { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
		public string Id { get; set; }

		/// <summary>
		/// Gets or sets the interests.
		/// </summary>
		[JsonPropertyName("interests")]
		public Dictionary<string, bool> Interests { get; set; }

		/// <summary>
		/// Gets or sets the ip opt.
		/// </summary>
		[JsonPropertyName("ip_opt")]
		public string IpOpt { get; set; }

		/// <summary>
		/// Gets or sets the ip signup.
		/// </summary>
		[JsonPropertyName("ip_signup")]
		public string IpSignup { get; set; }

		/// <summary>
		/// Gets or sets the language.
		/// </summary>
		[JsonPropertyName("language")]
		public string Language { get; set; }

		/// <summary>
		/// Gets or sets the last changed.
		/// </summary>
		[JsonPropertyName("last_changed")]
		public string LastChanged { get; set; }

		/// <summary>
		/// Gets or sets the links.
		/// </summary>
		[JsonPropertyName("_links")]
		public IEnumerable<Link> Links { get; set; }

		/// <summary>
		/// Gets or sets the list id.
		/// </summary>
		[JsonPropertyName("list_id")]
		public string ListId { get; set; }

		/// <summary>
		/// Gets the location.
		/// </summary>
		[JsonPropertyName("location")]
		public Location Location { get; set; }

		/// <summary>
		/// Gets or sets the marketing permissions.
		/// </summary>
		[JsonPropertyName("marketing_permissions")]
		public IEnumerable<MarketingPermission> MarketingPermissions { get; set; }

		/// <summary>
		/// Gets or sets the member rating.
		/// </summary>
		[JsonPropertyName("member_rating")]
		public int MemberRating { get; set; }

		/// <summary>
		/// Gets or sets the merge fields.
		/// </summary>
		[JsonPropertyName("merge_fields")]
		public Dictionary<string, object> MergeFields { get; set; }

		/// <summary>
		/// Gets or sets the number of tags.
		/// </summary>
		[JsonPropertyName("tags_count")]
		public int TagsCount { get; set; }

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		[JsonPropertyName("tags")]
    [JsonConverter(typeof(MemberTagListJsonConverter))] // This converted is used to serialize the tag list to a simple array of strings for PUT/POST requests
		public List<MemberTag> Tags { get; set; }

		/// <summary>
		/// Gets or sets the last Note.
		/// </summary>
		[JsonPropertyName("last_note")]
		public MemberLastNote LastNote { get; set; }

		/// <summary>
		/// Gets or sets the stats.
		/// </summary>
		[JsonPropertyName("stats")]
		public MemberStats Stats { get; set; }

		/// <summary>
		/// Sets the member's status unless they are new.  Then you need to use the <see cref="StatusIfNew"/> property.  Default value is <see cref="Status.Undefined"/>  
		/// </summary>
		[JsonPropertyName("status")]
		[JsonConverter(typeof(StringEnumDescriptionConverter<Status>))]
		public Status Status { get; set; }

		[JsonPropertyName("status_if_new")]
		[JsonConverter(typeof(StringEnumDescriptionConverter<Status>))]
		public Status StatusIfNew { get; set; }

		[JsonPropertyName("unsubscribe_reason")]
		public string UnsubscribeReason { get; set; }

		/// <summary>
		/// Gets or sets the timestamp opt.
		/// </summary>
		[JsonPropertyName("timestamp_opt")]
		public string TimestampOpt { get; set; }

		/// <summary>
		/// Gets or sets the timestamp signup.
		/// </summary>
		[JsonPropertyName("timestamp_signup")]
		public string TimestampSignup { get; set; }

		/// <summary>
		/// Gets or sets the unique email id.
		/// </summary>
		[JsonPropertyName("unique_email_id")]
		public string UniqueEmailId { get; set; }

		/// <summary>
		/// Gets or sets a value indicating whether vip.
		/// </summary>
		[JsonPropertyName("vip")]
		public bool Vip { get; set; }

    /// <summary>
    /// Gets the ID used in the Mailchimp web application. <para>View this member in your Mailchimp account at https://{dc}.admin.mailchimp.com/lists/members/view?id={web_id}.</para>
    /// </summary>
    [JsonPropertyName("web_id")]
    public int WebId { get; set; }
}