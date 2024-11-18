using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class ConnectedWebsiteResponse
{
    [JsonPropertyName("sites")]
    public IEnumerable<Site> Sites { get; set; } = new HashSet<Site>();

    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; } = new HashSet<Link>();
}