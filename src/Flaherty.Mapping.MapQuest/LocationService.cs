// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationService.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location service.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using System;
    using System.IO;
    using System.Linq;

    using Flaherty.Services;

    using Newtonsoft.Json;

    /// <summary>
    /// The location service.
    /// </summary>
    public class LocationService : RestService<ILocationRequest, Location>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationService"/> class.
        /// </summary>
        /// <param name="license">
        /// The license.
        /// </param>
        /// <param name="apiKey">
        /// The API key.
        /// </param>
        /// <param name="readTimeout">
        /// The read timeout.
        /// </param>
        /// <param name="writeTimeout">
        /// The write timeout.
        /// </param>
        public LocationService(License license, string apiKey, int? readTimeout = null, int? writeTimeout = null)
            : base(
                license == License.Licensed
                    ? new Uri("http://www.mapquestapi.com/geocoding/v1")
                    : new Uri("http://open.mapquestapi.com/geocoding/v1"),
                apiKey,
                null,
                readTimeout,
                writeTimeout)
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
                Country = country,
                State = administrativeArea,
                PostalCode = postalCode,
                City = locality,
                Street = street,
                MaxResults = maxResults
            };

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
            var locationRequest = (LocationRequest)request;
            request.Key = this.UsernameOrApiKey;
            return
                new Uri(string.Format("{0}/{1}?{2}", this.BaseUri, locationRequest.Method, request.ToParameterString()));
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
            var response = serializer.Deserialize<MapQuestResponse>(jsonTextReader);
            if (response != null && response.Results.Any() && response.Results.First().Locations.Any())
            {
                return response.Results.First().Locations.First();
            }

            return null;
        }
    }
}
