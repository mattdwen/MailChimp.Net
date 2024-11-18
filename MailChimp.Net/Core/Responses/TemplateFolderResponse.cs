﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateFolderResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The template folder response.
/// </summary>
public class TemplateFolderResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TemplateFolderResponse"/> class.
    /// </summary>
    public TemplateFolderResponse()
    {
        Folders = new HashSet<Folder>();
    }

    /// <summary>
    /// Gets or sets the folders.
    /// </summary>
    [JsonPropertyName("folders")]
    public IEnumerable<Folder> Folders { get; set; }
}