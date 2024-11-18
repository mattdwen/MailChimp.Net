using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class SiteScript
{
    [JsonPropertyName("url")]
    public string Url { get; set; }

    [JsonPropertyName("fragment")]
    public string Fragment { get; set; }
}