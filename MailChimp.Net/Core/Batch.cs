using System;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

	public class Batch
	{
		/// <summary>
		/// A string that uniquely identifies this batch request.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		/// The status of the batch call.
		/// Possible Values:
		/// pending - started - finished
		/// </summary>
		public string Status { get; set; }

		/// <summary>
		/// The total number of operations to complete as part of this batch request. 
		/// For GET requests requiring pagination, each page counts as a separate operation.
		/// </summary>
		[JsonPropertyName("total_operations")]
		public int TotalOperations { get; set; }

	    [System.ComponentModel.Browsable(false), Obsolete("Spelling corrected to FinishedOperations"), JsonIgnore]
	    public int FinishedOperpations
	    {
	        get => FinishedOperations;
	        set => FinishedOperations = value;
	    }

	    /// <summary>
		/// The number of completed operations. This includes operations that returned an error.
		/// </summary>
		[JsonPropertyName("finished_operations")]
		public int FinishedOperations { get; set; }

		/// <summary>
		/// The number of completed operations that returned an error.
		/// </summary>
		[JsonPropertyName("errored_operations")]
		public int ErroredOperations { get; set; }

		/// <summary>
		/// The time and date when the server received the batch request.
		/// </summary>
		[JsonPropertyName("submitted_at")]
		public DateTime? SubmittedAt { get; set; }

		/// <summary>
		/// The time and date when all operations in the batch request completed.
		/// </summary>
		[JsonPropertyName("completed_at")]
		public DateTime? CompletedAt { get; set; }

		/// <summary>
		/// The URL of the gzipped archive of the results of all the operations.
		/// </summary>
		[JsonPropertyName("response_body_url")]
		public string ResponseBodyUrl { get; set; }
	}
