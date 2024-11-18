// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagsResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

	public class TagsResponse
	{
		public TagsResponse()
		{
			Tags = new List<MemberTag>();
		}

		/// <summary>
		/// Gets or sets the tags.
		/// </summary>
		[JsonPropertyName("tags")]
		public IEnumerable<MemberTag> Tags { get; set; }

		/// <summary>
		/// Gets or sets the number of tags.
		/// </summary>
		[JsonPropertyName("total_items")]
		public int NumberOfTags { get; set; }
	}
