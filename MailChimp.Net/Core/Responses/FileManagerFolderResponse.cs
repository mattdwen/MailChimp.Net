using System.Collections.Generic;
using MailChimp.Net.Models;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class FileManagerFolderResponse
{
    public FileManagerFolderResponse()
    {
        Folders = new HashSet<FileManagerFolder>();
        Links = new HashSet<Link>();
    }

    [JsonPropertyName("folders")]
    public IEnumerable<FileManagerFolder> Folders { get; set; }

    [JsonPropertyName("total_items")]
    public int TotalItems { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }
}
