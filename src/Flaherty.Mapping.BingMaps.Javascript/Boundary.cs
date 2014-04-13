// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Boundary.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   A location rectangle defined by north and south latitudes and east and west longitudes.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System;

    using Flaherty.Mapping.BingMaps.Javascript.Json;

    using Newtonsoft.Json;

    /// <summary>
    /// A location rectangle defined by north and south latitudes and east and west longitudes.
    /// </summary>
    [JsonConverter(typeof(BoundaryConverter))]
    public class Boundary : BingMapsObject, IBoundary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Boundary"/> class.
        /// </summary>
        /// <param name="northLatitude">
        /// The north latitude.
        /// </param>
        /// <param name="westLongitude">
        /// The west longitude.
        /// </param>
        /// <param name="southLatitude">
        /// The south latitude.
        /// </param>
        /// <param name="eastLongitude">
        /// The east longitude.
        /// </param>
        public Boundary(double northLatitude, double westLongitude, double southLatitude, double eastLongitude)
        {
            this.NorthLatitude = northLatitude;
            this.WestLongitude = westLongitude;
            this.SouthLatitude = southLatitude;
            this.EastLongitude = eastLongitude;
        }

        /// <summary>
        /// Gets or sets the north latitude.
        /// </summary>
        public double NorthLatitude { get; set; }

        /// <summary>
        /// Gets or sets the west longitude.
        /// </summary>
        public double WestLongitude { get; set; }

        /// <summary>
        /// Gets or sets the south latitude.
        /// </summary>
        public double SouthLatitude { get; set; }

        /// <summary>
        /// Gets or sets the east longitude.
        /// </summary>
        public double EastLongitude { get; set; }

        /// <summary>
        /// Parses a string into a new boundary.
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
        public static Boundary Parse(string value)
        {
            var coords = value.Split(',');
            double northLatitude, westLongitude, southLatitude, eastLongitude;
            if (coords.Length != 4 || !double.TryParse(coords[0].Trim(), out northLatitude)
                || !double.TryParse(coords[1].Trim(), out westLongitude)
                || !double.TryParse(coords[2].Trim(), out southLatitude)
                || !double.TryParse(coords[3].Trim(), out eastLongitude))
            {
                throw new ArgumentException("Provided coordinates are not in the correct format.");
            }

            return new Boundary(northLatitude, westLongitude, southLatitude, eastLongitude);
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format(
                "{0},{1},{2},{3}",
                this.NorthLatitude,
                this.WestLongitude,
                this.SouthLatitude,
                this.EastLongitude);
        }

        /// <summary>
        /// Returns the JavaScript representation of the object.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        internal override string ToJavascript()
        {
            return string.Format("LocationRect.fromEdges(({0})", this);
        }
    }
}
