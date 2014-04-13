// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The address.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using Newtonsoft.Json;

    /// <summary>
    /// The address.
    /// </summary>
    public class Address : IAddress
    {
        /// <summary>
        /// Gets the street.
        /// </summary>
        [JsonProperty("addressLine")]
        public string Street { get; internal set; }

        /// <summary>
        /// Gets the administrative area.
        /// </summary>
        [JsonProperty("adminDistrict")]
        public string AdministrativeArea { get; internal set; }

        /// <summary>
        /// Gets the administrative area 2.
        /// </summary>
        [JsonProperty("adminDistrict2")]
        public string AdministrativeArea2 { get; internal set; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        [JsonProperty("countryRegion")]
        public string Country { get; internal set; }

        /// <summary>
        /// Gets the formatted address.
        /// </summary>
        [JsonProperty("formattedAddress")]
        public string FormattedAddress { get; internal set; }

        /// <summary>
        /// Gets the locality.
        /// </summary>
        [JsonProperty("locality")]
        public string Locality { get; internal set; }

        /// <summary>
        /// Gets the postal code.
        /// </summary>
        [JsonProperty("postalCode")]
        public string PostalCode { get; internal set; }
    }
}