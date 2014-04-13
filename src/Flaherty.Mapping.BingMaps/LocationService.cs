// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationService.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using System;
    using System.IO;
    using System.Linq;

    using Flaherty.Services;

    using Newtonsoft.Json;

    /// <summary>
    /// The location service.
    /// </summary>
    public class LocationService : RestService<ILocationRequest, Location>, ILocationService
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationService"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The API key.
        /// </param>
        /// <param name="readTimeout">
        /// The read timeout.
        /// </param>
        /// <param name="writeTimeout">
        /// The write timeout.
        /// </param>
        public LocationService(string apiKey, int? readTimeout = null, int? writeTimeout = null)
            : base(new Uri("http://dev.virtualearth.net/REST/v1/Locations"), apiKey, null, readTimeout, writeTimeout)
        {
        }

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
        public ILocation Locate(
            string country,
            string administrativeArea,
            string postalCode,
            string locality,
            string street,
            int? maxResults,
            ILocateOptions options)
        {
            var request = new AddressLocationRequest
                              {
                                  CountryRegion = country,
                                  AdminDistrict = administrativeArea,
                                  PostalCode = postalCode,
                                  Locality = locality,
                                  AddressLine = street,
                                  MaxResults = maxResults
                              };
            var locateOptions = options as LocateOptions;
            if (locateOptions != null)
            {
                request.IncludeNeighborhood = locateOptions.IncludeNeighborhood;
                request.Include = locateOptions.Include;
            }

            return this.Get(request);
        }

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
        /// The address line.
        /// </param>
        /// <returns>
        /// The <see cref="ILocation"/>.
        /// </returns>
        public ILocation Locate(
            string country,
            string administrativeArea,
            string postalCode,
            string locality,
            string street)
        {
            return this.Locate(country, administrativeArea, postalCode, locality, street, null, null);
        }

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
        public ILocation Locate(
            double latitude,
            double longitude,
            int? maxResults,
            ILocateOptions options)
        {
            var request = new CoordinatesLocationRequest
            {
                Latitude = latitude,
                Longitude = longitude,
                MaxResults = maxResults
            };
            var locateOptions = options as LocateOptions;
            if (locateOptions != null)
            {
                request.IncludeNeighborhood = locateOptions.IncludeNeighborhood;
                request.Include = locateOptions.Include;
            }

            return this.Get(request);
        }

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
        public ILocation Locate(
            double latitude,
            double longitude)
        {
            return this.Locate(latitude, longitude, null, null);
        }

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
        public ILocation Locate(
            string query,
            int? maxResults,
            ILocateOptions options)
        {
            var request = new QueryLocationRequest
            {
                Query = query,
                MaxResults = maxResults
            };
            var locateOptions = options as LocateOptions;
            if (locateOptions != null)
            {
                request.IncludeNeighborhood = locateOptions.IncludeNeighborhood;
                request.Include = locateOptions.Include;
            }

            return this.Get(request);
        }

        /// <summary>
        /// Gets a location from a query.
        /// </summary>
        /// <param name="query">
        /// The query.
        /// </param>
        /// <returns>
        /// The <see cref="ILocation"/>.
        /// </returns>
        public ILocation Locate(string query)
        {
            return this.Locate(query, null, null);
        }

        /// <summary>
        /// Constructs the request URI for the supplied request object.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The request <see cref="Uri"/>.
        /// </returns>
        protected override Uri ConstructRequestUri(ILocationRequest request)
        {
            request.Key = this.UsernameOrApiKey;
            return new Uri(string.Format("{0}?{1}", this.BaseUri, request.ToParameterString()));
        }

        /// <summary>
        /// Parses the response.
        /// </summary>
        /// <param name="stream">
        /// The stream.
        /// </param>
        /// <returns>
        /// The <see cref="Location"/>.
        /// </returns>
        protected override Location ParseResponse(Stream stream)
        {
            var serializer = new JsonSerializer();
            var jsonTextReader = new JsonTextReader(new StreamReader(stream));
            var response = serializer.Deserialize<BingMapsResponse<Location>>(jsonTextReader);
            if (response != null && response.ResourceSets.Any() && response.ResourceSets.First().Resources.Any())
            {
                return response.ResourceSets.First().Resources.First();
            }

            return null;
        }
    }
}
