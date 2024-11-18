﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TemplateResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The template response.
/// </summary>
public class TemplateResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TemplateResponse"/> class.
    /// </summary>
    public TemplateResponse()
    {
        Templates = new HashSet<Template>();
    }

    /// <summary>
    /// Gets or sets the templates.
    /// </summary>
    [JsonPropertyName("templates")]
    public IEnumerable<Template> Templates { get; set; }
}