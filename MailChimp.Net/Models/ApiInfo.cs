// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ApiInfo.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The api info.
/// </summary>
public class ApiInfo
{
    /// <summary>
    /// Gets or sets the account id.
    /// </summary>
    [JsonPropertyName("account_id")]
    public string AccountId { get; set; }

    [JsonPropertyName("login_id")]
    public string LoginId { get; set; }
    /// <summary>
    /// Gets or sets the account name.
    /// </summary>
    [JsonPropertyName("account_name")]
    public string AccountName { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }
    [JsonPropertyName("last_name")]
    public string LastName { get; set; }
    [JsonPropertyName("username")]
    public string UserName { get; set; }
    [JsonPropertyName("avatar_url")]
    public string AvatarUrl { get; set; }
    [JsonPropertyName("role")]
    public string Role { get; set; }
    [JsonPropertyName("member_since")]
    public string MemberSince { get; set; }
    [JsonPropertyName("pricing_plan_type")]
    public string PricingPlanType { get; set; }
    [JsonPropertyName("first_payment")]
    public string FirstPayment { get; set; }
    [JsonPropertyName("account_timezone")]
    public string AccountTimezone { get; set; }
    [JsonPropertyName("account_industry")]
    public string AccountIndustry { get; set; }
    [JsonPropertyName("pro_enabled")]
    public bool ProEnabled { get; set; }

    [JsonPropertyName("industry_stats")]
    public IndustryStats IndustryStats { get; set; }

    /// <summary>
    /// Gets or sets the contact.
    /// </summary>
    [JsonPropertyName("contact")]
    public ApiContact Contact { get; set; }

    /// <summary>
    /// Gets or sets the last login.
    /// </summary>
    [JsonPropertyName("last_login")]
    public string LastLogin { get; set; }



    /// <summary>
    /// Gets or sets the links.
    /// </summary>
    [JsonPropertyName("_links")]
    public Link[] Links { get; set; }

    /// <summary>
    /// Gets or sets the total subscribers.
    /// </summary>
    [JsonPropertyName("total_subscribers")]
    public int TotalSubscribers { get; set; }
}