// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILocationService.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Interface for describing a location service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping
{
    /// <summary>
    /// Interface for describing a location service.
    /// </summary>
    public interface ILocationService
    {
        /// <summary>
        /// Gets a location by address.
        /// </summary>
        /// <param name="country">
        /// The country.
        /// </param>
        /// <param name="administrativeArea">
        /// The administrative area.
        /// </param>
        /// <param name="postalCode">
        /// The postal code.
        /// </param>
        /// <param name="locality">
        /// The locality.
        /// </param>
        /// <param name="street">
        /// The street address.
        /// </param>
        /// <param name="maxResults">
        /// The max results.
        /// </param>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <returns>
        /// The <see cref="ILocation"/>.
        /// </returns>
        ILocation Locate(
            string country,
            string administrativeArea,
            string postalCode,
            string locality,
            string street,
            int? maxResults,
            ILocateOptions options);

        /// <summary>
        /// Gets a location by address.
        /// </summary>
        /// <param name="country">
        /// The country.
        /// </param>
        /// <param name="administrativeArea">
        /// The administrative area.
        /// </param>
        /// <param name="postalCode">
        /// The postal code.
        /// </param>
        /// <param name="locality">
        /// The locality.
        /// </param>
        /// <param name="street">
        /// The street address.
        /// </param>
        /// <returns>
        /// The <see cref="ILocation"/>.
        /// </returns>
        ILocation Locate(
            string country,
            string administrativeArea,
            string postalCode,
            string locality,
            string street);

        /// <summary>
        /// Gets a location by point.
        /// </summary>
        /// <param name="latitude">
        /// The latitude.
        /// </param>
        /// <param name="longitude">
        /// The longitude.
        /// </param>
        /// <param name="maxResults">
        /// The max results.
        /// </param>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <returns>
        /// The <see cref="ILocation"/>.
        /// </returns>
        ILocation Locate(double latitude, double longitude, int? maxResults, ILocateOptions options);

        /// <summary>
        /// Gets a location by point.
        /// </summary>
        /// <param name="latitude">
        /// The latitude.
        /// </param>
        /// <param name="longitude">
        /// The longitude.
        /// </param>
        /// <returns>
        /// The <see cref="ILocation"/>.
        /// </returns>
        ILocation Locate(double latitude, double longitude);

        /// <summary>
        /// Gets a location from a query.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <param name="maxResults">
        /// The max results.
        /// </param>
        /// <param name="options">
        /// The options.
        /// </param>
        /// <returns>
        /// The <see cref="ILocation"/>.
        /// </returns>
        ILocation Locate(string query, int? maxResults, ILocateOptions options);

        /// <summary>
        /// Gets a location from a query.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <returns>
        /// The <see cref="ILocation"/>.
        /// </returns>
        ILocation Locate(string query);
    }
}
