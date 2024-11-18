// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TriggerSettings.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The trigger settings.
/// </summary>
public class TriggerSettings
{
    /// <summary>
    /// Gets or sets the runtime.
    /// </summary>
    [JsonPropertyName("runtime")]
    public Runtime Runtime { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether send immediately.
    /// </summary>
    [JsonPropertyName("send_immediately")]
    public bool SendImmediately { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether trigger on import.
    /// </summary>
    [JsonPropertyName("trigger_on_import")]
    public bool TriggerOnImport { get; set; }

    /// <summary>
    /// Gets or sets the workflow emails count.
    /// </summary>
    [JsonPropertyName("workflow_emails_count")]
    public int WorkflowEmailsCount { get; set; }

    /// <summary>
    /// Gets or sets the workflow type.
    /// </summary>
    [JsonPropertyName("workflow_type")]
    public string WorkflowType { get; set; }
}