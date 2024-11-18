// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System.Text.Json.Serialization;

namespace MailChimp.Net.Models;

	/// <summary>
	/// The location.
	/// </summary>
	public class Location
	{
		public Location()
		{
			CountryCode = string.Empty;
			Timezone = string.Empty;
		}
		/// <summary>
		/// Gets or sets the country code.
		/// </summary>
		[JsonPropertyName("country_code")]
		public string CountryCode { get; set; }

		/// <summary>
		/// Gets or sets the dstoff.
		/// </summary>
		[JsonPropertyName("dstoff")]
		public int Dstoff { get; set; }

		/// <summary>
		/// Gets or sets the gmtoff.
		/// </summary>
		[JsonPropertyName("gmtoff")]
		public int Gmtoff { get; set; }

		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		[JsonPropertyName("latitude")]
		public decimal Latitude { get; set; }

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		[JsonPropertyName("longitude")]
		public decimal Longitude { get; set; }

		/// <summary>
		/// Gets or sets the timezone.
		/// </summary>
		[JsonPropertyName("timezone")]
		public string Timezone { get; set; }
	}