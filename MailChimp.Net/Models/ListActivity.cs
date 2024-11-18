using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class ListActivity
{

    [JsonPropertyName("day")]
    public string Day { get; set; }

    [JsonPropertyName("emails_sent")]
    public int EmailsSent { get; set; }

    [JsonPropertyName("unique_opens")]
    public int UniqueOpens { get; set; }

    [JsonPropertyName("recipient_clicks")]
    public int RecipientClicks { get; set; }

    [JsonPropertyName("hard_bounce")]
    public int HardBounce { get; set; }

    [JsonPropertyName("soft_bounce")]
    public int SoftBounce { get; set; }

    [JsonPropertyName("subs")]
    public int Subs { get; set; }

    [JsonPropertyName("unsubs")]
    public int Unsubs { get; set; }

    [JsonPropertyName("other_adds")]
    public int OtherAdds { get; set; }

    [JsonPropertyName("other_removes")]
    public int OtherRemoves { get; set; }
}
