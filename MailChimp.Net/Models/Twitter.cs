// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Twitter.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

/// <summary>
/// The twitter.
/// </summary>
public class Twitter
{
    /// <summary>
    /// Gets or sets the first tweet.
    /// </summary>
    [JsonPropertyName("first_tweet")]
    public string FirstTweet { get; set; }

    /// <summary>
    /// Gets or sets the last tweet.
    /// </summary>
    [JsonPropertyName("last_tweet")]
    public string LastTweet { get; set; }

    /// <summary>
    /// Gets or sets the retweets.
    /// </summary>
    [JsonPropertyName("retweets")]
    public int Retweets { get; set; }

    /// <summary>
    /// Gets or sets the statuses.
    /// </summary>
    [JsonPropertyName("retweets")]
    public IEnumerable<Status> Statuses { get; set; }

    /// <summary>
    /// Gets or sets the tweets.
    /// </summary>
    [JsonPropertyName("tweets")]
    public int Tweets { get; set; }
}