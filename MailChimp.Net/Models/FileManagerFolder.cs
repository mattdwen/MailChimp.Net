using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class FileManagerFolder
{

    public FileManagerFolder()
    {
        Links = new HashSet<Link>();
    }

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("file_count")]
    public int FileCount { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }
}
