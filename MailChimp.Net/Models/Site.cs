using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Site
{
    [JsonPropertyName("foreign_id")]
    public string ForeignId { get; set; }

    [JsonPropertyName("store_id")]
    public string StoreId { get; set; }

    [JsonPropertyName("platform")]
    public string Platform { get; set; }

    [JsonPropertyName("domain")]
    public string Domain { get; set; }

    [JsonPropertyName("site_script")]
    public SiteScript SiteScript { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("_links")]
    public List<Link> Links { get; set; }
}
