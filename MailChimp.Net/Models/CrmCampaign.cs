using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public abstract class CrmCampaign
{
    [JsonPropertyName("campaign")]
    public bool CreateCampaignInAccount { get; set; }

    [JsonPropertyName("notes")]
    public bool UpdateNotesForCampaign { get; set; }
}