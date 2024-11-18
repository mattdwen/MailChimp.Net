// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Note.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;
using System;

namespace MailChimp.Net.Models;

	/// <summary>
	/// The note.
	/// </summary>
	public class Note
	{
		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		[JsonPropertyName("note")]
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the created at.
		/// </summary>
		[JsonPropertyName("created_at")]
		public DateTime? CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		[JsonPropertyName("created_by")]
		public string CreatedBy { get; set; }

		/// <summary>
		/// Gets or sets the email id.
		/// </summary>
		[JsonPropertyName("email_id")]
		public string EmailId { get; set; }

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[JsonPropertyName("id")]
		public int Id { get; set; }

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
		/// Gets or sets the updated at.
		/// </summary>
		[JsonPropertyName("updated_at")]
		public DateTime? UpdatedAt { get; set; }
	}

	public class MemberLastNote
	{
		public MemberLastNote()
		{
			Body = string.Empty;
        CreatedAt = null;
			CreatedBy = string.Empty;
		}

		/// <summary>
		/// Gets or sets the id.
		/// </summary>
		[JsonPropertyName("note_id")]
		public int Id { get; set; }

		/// <summary>
		/// Gets or sets the body.
		/// </summary>
		[JsonPropertyName("note")]
		public string Body { get; set; }

		/// <summary>
		/// Gets or sets the created at.
		/// </summary>
		[JsonPropertyName("created_at")]
		public DateTime? CreatedAt { get; set; }

		/// <summary>
		/// Gets or sets the created by.
		/// </summary>
		[JsonPropertyName("created_by")]
		public string CreatedBy { get; set; }

	}