using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Capsule
{
    [JsonPropertyName("notes")]
    public bool UpdateNotesForCampaign { get; set; }
}