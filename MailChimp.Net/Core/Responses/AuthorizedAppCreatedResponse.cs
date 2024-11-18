// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthorizedAppCreatedResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The authorized app created response.
/// </summary>
public class AuthorizedAppCreatedResponse
{
    /// <summary>
    /// Gets or sets the access token.
    /// </summary>
    [JsonPropertyName("access_token")]
    public string AccessToken { get; set; }

    /// <summary>
    /// Gets or sets the viewer token.
    /// </summary>
    [JsonPropertyName("viewer_token")]
    public string ViewerToken { get; set; }
}