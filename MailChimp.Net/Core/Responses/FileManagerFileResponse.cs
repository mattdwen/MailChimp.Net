using System.Collections.Generic;
using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

public class FileManagerFileResponse : BaseResponse
{

    public FileManagerFileResponse()
    {
        Files = new HashSet<FileManagerFile>();
    }

    [JsonPropertyName("files")]
    public IEnumerable<FileManagerFile> Files { get; set; }

    [JsonPropertyName("total_file_size")]
    public int TotalFileSize { get; set; }
}
