using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

	public class BatchRequest
	{
		[JsonPropertyName("operations")]
		public IEnumerable<Operation> Operations { get; set; }
	}
