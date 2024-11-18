using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Combination
{
    [JsonPropertyName("id")]
    public string Id { get; set; }
}