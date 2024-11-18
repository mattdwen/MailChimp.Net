﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MemberResponse.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

using MailChimp.Net.Models;

using System.Text.Json.Serialization;

namespace MailChimp.Net.Core;

/// <summary>
/// The member response.
/// </summary>
public class MemberResponse : BaseResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MemberResponse"/> class.
    /// </summary>
    public MemberResponse()
    {
        Members = new HashSet<Member>();
    }

    /// <summary>
    /// Gets or sets the list id.
    /// </summary>
    [JsonPropertyName("list_id")]
    public string ListId { get; set; }

    /// <summary>
    /// Gets or sets the members.
    /// </summary>
    [JsonPropertyName("members")]
    public IEnumerable<Member> Members { get; set; }
}