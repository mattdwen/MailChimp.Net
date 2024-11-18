using System.Collections.Generic;

namespace MailChimp.Net.Models;

	using System.Text.Json.Serialization;

	public class MergeField
	{

		public MergeField()
		{
			Links = new HashSet<Link>();
			HelpText = string.Empty;
			DefaultValue = string.Empty;
		}

		[JsonPropertyName("merge_id")]
		public int MergeId { get; set; }

		[JsonPropertyName("tag")]
		public string Tag { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("type")]
		public string Type { get; set; }

		[JsonPropertyName("required")]
		public bool Required { get; set; }

		[JsonPropertyName("default_value")]
		public string DefaultValue { get; set; }

		[JsonPropertyName("public")]
		public bool Public { get; set; }

		[JsonPropertyName("display_order")]
		public int DisplayOrder { get; set; }

		[JsonPropertyName("options")]
		public Options Options { get; set; }

		[JsonPropertyName("help_text")]
		public string HelpText { get; set; }

		[JsonPropertyName("list_id")]
		public string ListId { get; set; }

		[JsonPropertyName("_links")]
		public IEnumerable<Link> Links { get; set; }
	}
