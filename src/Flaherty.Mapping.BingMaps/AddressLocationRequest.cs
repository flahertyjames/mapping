// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressLocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using Flaherty.Services;

    /// <summary>
    /// The location request.
    /// </summary>
    public class AddressLocationRequest : LocationRequest
    {
        /// <summary>
        /// Gets or sets the admin district.
        /// </summary>
        /// <value>
        /// The admin district.
        /// </value>
        [Parameter("adminDistrict")]
        public string AdminDistrict { get; set; }

        /// <summary>
        /// Gets or sets the locality.
        /// </summary>
        /// <value>
        /// The locality.
        /// </value>
        [Parameter("locality")]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>
        /// The postal code.
        /// </value>
        [Parameter("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the address line.
        /// </summary>
        /// <value>
        /// The address line.
        /// </value>
        [Parameter("addressLine")]
        public string AddressLine { get; set; }

        /// <summary>
        /// Gets or sets the country region.
        /// </summary>
        /// <value>
        /// The country region.
        /// </value>
        [Parameter("countryRegion")]
        public string CountryRegion { get; set; }
    }
}
