using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace MailChimp.Net.Models;

/// <summary>
/// </summary>
public class ContentTemplate
{
    /// <summary>
    /// </summary>
    [JsonPropertyName("id")]
    public int Id { get; set; }

    /// <summary>
    /// </summary>
    [JsonPropertyName("sections")]
    public Dictionary<string, object> Sections { get; set; }
}
