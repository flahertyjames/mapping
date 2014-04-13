// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coordinates.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   A location defined by a latitude and longitude.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System;

    using Flaherty.Mapping.BingMaps.Javascript.Json;

    using Newtonsoft.Json;

    /// <summary>
    /// A location defined by a latitude and longitude.
    /// </summary>
    [JsonConverter(typeof(CoordinatesConverter))]
    public class Coordinates : BingMapsObject, ICoordinates
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coordinates"/> class.
        /// </summary>
        /// <param name="latitude">
        /// The latitude.
        /// </param>
        /// <param name="longitude">
        /// The longitude.
        /// </param>
        public Coordinates(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Gets the JavaScript type name.
        /// </summary>
        internal override string JavascriptTypeName
        {
            get
            {
                return "Microsoft.Maps.Location";
            }
        }

        /// <summary>
        /// Parses a string into a new coordinates object.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="Boundary"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when provided coordinates are not in the correct format.
        /// </exception>
        public static Coordinates Parse(string value)
        {
            var coords = value.Split(',');
            double latitude, longitude;
            if (coords.Length != 2 || !double.TryParse(coords[0].Trim(), out latitude) || !double.TryParse(coords[1].Trim(), out longitude))
            {
                throw new ArgumentException("Provided coordinates are not in the correct format.");
            }

            return new Coordinates(latitude, longitude);
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0},{1}", this.Latitude, this.Longitude);
        }
    }
}
