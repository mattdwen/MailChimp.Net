using MailChimp.Net.Models;
using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;

namespace MailChimp.Net.Core;


public class ReplicateResponse
{
    public ReplicateResponse()
    {
        Links = new HashSet<Link>();
    }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("create_time")]
    public DateTime CreateTime { get; set; }

    [JsonPropertyName("archive_url")]
    public string ArchiveUrl { get; set; }

    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("emails_sent")]
    public int EmailsSent { get; set; }

    [JsonPropertyName("send_time")]
    public string SendTime { get; set; }

    [JsonPropertyName("content_type")]
    public string ContentType { get; set; }

    [JsonPropertyName("recipients")]
    public Recipient Recipients { get; set; }

    [JsonPropertyName("settings")]
    public Setting Settings { get; set; }

    [JsonPropertyName("tracking")]
    public Tracking Tracking { get; set; }

    [JsonPropertyName("delivery_status")]
    public DeliveryStatus DeliveryStatus { get; set; }

    [JsonPropertyName("_links")]
    public IEnumerable<Link> Links { get; set; }
}
