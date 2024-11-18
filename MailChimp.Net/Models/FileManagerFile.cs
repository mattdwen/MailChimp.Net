// --------------------------------------------------------------------------------------------------------------------
// <copyright file="File.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// <summary>
//   The file manager file.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The file manager file.
/// </summary>
public class FileManagerFile
{

    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("folder_id")]
    public int FolderId { get; set; }

    [JsonPropertyName("type")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<FileType>))]
    public FileType Type { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("full_size_url")]
    public string FullSizeUrl { get; set; }

    [JsonPropertyName("thumbnail_url")]
    public string ThumbnailUrl { get; set; }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime? CreatedAt { get; set; }

    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    [JsonPropertyName("width")]
    public int Width { get; set; }

    [JsonPropertyName("height")]
    public int Height { get; set; }

    [JsonPropertyName("_links")]
    public IList<Link> Links { get; set; }
}
