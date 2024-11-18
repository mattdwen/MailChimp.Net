// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BatchResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// <summary>
//   The batch response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The batch response.
/// </summary>
public class BatchResponse : BaseResponse
{
    [JsonPropertyName("batches")]
    public IEnumerable<Batch> Batches { get; set; }
}
