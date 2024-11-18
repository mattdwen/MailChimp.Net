using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;


public class Options
{
    public Options()
    {
        Choices = new HashSet<string>();
    }

    [JsonPropertyName("size")]
    public int Size { get; set; }

    [JsonPropertyName("default_country")]
    public int DefaultCountry { get; set; }

    [JsonPropertyName("phone_format")]
    public string PhoneFormat { get; set; }

    [JsonPropertyName("date_format")]
    public string DateFormat { get; set; }

    [JsonPropertyName("choices")]
    public IEnumerable<string> Choices { get; set; }
}
