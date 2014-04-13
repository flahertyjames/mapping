// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coordinates.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The coordinates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using System;
    using System.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The coordinates.
    /// </summary>
    public class Coordinates : ICoordinates
    {
        [JsonProperty("usageTypes")]
        private string[] usageTypes = { };

        [JsonProperty("coordinates")]
        private double[] coordinates = { };

        /// <summary>
        /// Gets or sets the calculation method.
        /// </summary>
        /// <value>
        /// The calculation method.
        /// </value>
        [JsonProperty("calculationMethod")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GeocodeCalculationMethod CalculationMethod { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        public double Latitude
        {
            get
            {
                return this.coordinates[0];
            }

            set
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        public double Longitude
        {
            get
            {
                return this.coordinates[1];
            }

            set
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Gets the usage types.
        /// </summary>
        /// <value>
        /// The usage types.
        /// </value>
        public GeocodeUsageType[] UsageTypes
        {
            get
            {
                return this.usageTypes.Select(x => (GeocodeUsageType)Enum.Parse(typeof(GeocodeUsageType), x)).ToArray();
            }
        }
    }
}