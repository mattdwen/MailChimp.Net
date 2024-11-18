using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core.Responses;

public class ListEventResponse : BaseResponse
{
    [JsonPropertyName("events")]
    public IEnumerable<ListEvent> Events { get; set; } = new List<ListEvent>();
}
