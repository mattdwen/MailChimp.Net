// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Template.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;
using MailChimp.Net.Core;

namespace MailChimp.Net.Models;

/// <summary>
/// The template.
/// </summary>
public class Template
{
    /// <summary>
    /// Gets or sets a value indicating whether active.
    /// </summary>
    [JsonPropertyName("active")]
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets the category.
    /// </summary>
    [JsonPropertyName("category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or sets the created by.
    /// </summary>
    [JsonPropertyName("created_by")]
    public string CreatedBy { get; set; }

    /// <summary>
    /// Gets or sets the date created.
    /// </summary>
    [JsonPropertyName("date_created")]
    public string DateCreated { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether drag and drop.
    /// </summary>
    [JsonPropertyName("drag_and_drop")]
    public bool DragAndDrop { get; set; }

    /// <summary>
    /// Gets or sets the folder id.
    /// </summary>
    [JsonPropertyName("folder_id")]
    public string FolderId { get; set; }

    /// <summary>
    /// Gets or sets the id.
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether responsive.
    /// </summary>
    [JsonPropertyName("responsive")]
    public bool Responsive { get; set; }

    /// <summary>
    /// Gets or sets the share url.
    /// </summary>
    [JsonPropertyName("share_url")]
    public string ShareUrl { get; set; }

    /// <summary>
    /// Gets or sets the thumbnail.
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public string Thumbnail { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    [JsonPropertyName("type")]
    [JsonConverter(typeof(StringEnumDescriptionConverter<TemplateType>))]
    public TemplateType Type { get; set; }
}