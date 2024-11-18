// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Archive.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The archive.
/// </summary>
public class Archive
{
    /// <summary>
    /// Gets or sets the archive content. [Required]
    /// </summary>
    [JsonPropertyName("archive_content"), JsonRequired]
    public string ArchiveContent { get; set; }

    /// <summary>
    /// Gets or sets the archive type.
    /// </summary>
    [JsonPropertyName("archive_type")]
    public string ArchiveType { get; set; }
}