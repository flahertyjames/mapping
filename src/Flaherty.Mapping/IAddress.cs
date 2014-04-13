// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAddress.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The address interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping
{
    /// <summary>
    /// The address interface.
    /// </summary>
    public interface IAddress
    {
        /// <summary>
        /// Gets the street.
        /// </summary>
        string Street { get; }

        /// <summary>
        /// Gets the administrative area.
        /// </summary>
        string AdministrativeArea { get; }

        /// <summary>
        /// Gets the administrative area 2.
        /// </summary>
        string AdministrativeArea2 { get; }

        /// <summary>
        /// Gets the locality.
        /// </summary>
        string Locality { get; }

        /// <summary>
        /// Gets the country.
        /// </summary>
        string Country { get; }

        /// <summary>
        /// Gets the postal code.
        /// </summary>
        string PostalCode { get; }
    }
}
