using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core.Requests
{
    public class ConnectedWebsiteRequest
    {
        [JsonPropertyName("domain")]
        public string domain { get; set; }

        [JsonPropertyName("foreign_id")]
        public string foreign_id { get; set; }
    }
}