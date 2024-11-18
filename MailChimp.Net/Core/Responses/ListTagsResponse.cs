using MailChimp.Net.Models;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace MailChimp.Net.Core;

public class ListTagsResponse : BaseResponse
{
    [JsonPropertyName("tags")]
    public IEnumerable<ListTag> Tags { get; set; }
}
