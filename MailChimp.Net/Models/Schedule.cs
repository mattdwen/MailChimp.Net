using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

public class Schedule
{
    [JsonPropertyName("hour")]
    public int Hour { get; set; }

    [JsonPropertyName("daily_send")]
    public DailySend DailySend { get; set; }

    [JsonPropertyName("weekly_send_day")]
    public string DayOfWeekToSend { get; set; }

    [JsonPropertyName("monthly_send_date")]
    public int DayOfMonthToSend { get; set; }
}