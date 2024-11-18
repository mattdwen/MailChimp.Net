using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class ListTag
{
    /// <summary>
    /// Gets or sets the tag's name.
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the tag's id).
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }

}
