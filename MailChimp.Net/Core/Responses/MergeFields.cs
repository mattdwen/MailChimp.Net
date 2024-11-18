using System.Text.Json.Serialization;

namespace MailChimp.Net.Core.Responses;

public class MergeFields
{
    [JsonPropertyName("FNAME")]
    public string FirstName { get; set; }

    [JsonPropertyName("LNAME")]
    public string LastName { get; set; }

    [JsonPropertyName("ADDRESS")]
    public string Address { get; set; }

    [JsonPropertyName("PHONE")]
    public string Phone { get; set; }
}