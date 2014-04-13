// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Address.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The address.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    /// <summary>
    /// The address.
    /// </summary>
    public class Address : IAddress
    {
        /// <summary>
        /// Gets the street.
        /// </summary>
        public string Street { get; internal set; }

        /// <summary>
        /// Gets the administrative area.
        /// </summary>
        public string AdministrativeArea { get; internal set; }

        /// <summary>
        /// Gets the administrative area label.
        /// </summary>
        public string AdministrativeAreaLabel { get; internal set; }

        /// <summary>
        /// Gets the administrative area 2.
        /// </summary>
        public string AdministrativeArea2 { get; internal set; }

        /// <summary>
        /// Gets the administrative area 2 label.
        /// </summary>
        public string AdministrativeArea2Label { get; internal set; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        public string Country { get; internal set; }

        /// <summary>
        /// Gets the country label.
        /// </summary>
        public string CountryLabel { get; internal set; }

        /// <summary>
        /// Gets the locality.
        /// </summary>
        public string Locality { get; internal set; }

        /// <summary>
        /// Gets the locality label.
        /// </summary>
        public string LocalityLabel { get; internal set; }

        /// <summary>
        /// Gets the postal code.
        /// </summary>
        public string PostalCode { get; internal set; }

        /// <summary>
        /// Gets the side of street.
        /// </summary>
        public SideOfStreet SideOfStreet { get; internal set; }
    }
}