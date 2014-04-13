// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    using Flaherty.Services;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    /// <summary>
    /// The location response.
    /// </summary>
    public class Location : ILocation, IResponse
    {
        [JsonProperty("bbox")]
        private double[] boundingBox = { };

        [JsonProperty("matchCodes")]
        private string[] matchCodes = { };

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="address">
        /// The address.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        public Location(Address address, Coordinates point)
        {
            this.Address = address;
            this.Point = point;
        }

        /// <summary>
        /// Gets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [JsonProperty("address")]
        public IAddress Address { get; internal set; }

        /// <summary>
        /// Gets the boundary.
        /// </summary>
        /// <value>
        /// The bounding box.
        /// </value>
        public IBoundary Boundary
        {
            get
            {
                if (this.boundingBox != null && this.boundingBox.Length == 4)
                {
                    return new Boundary
                               {
                                   SouthLatitude = this.boundingBox[0],
                                   WestLongitude = this.boundingBox[1],
                                   NorthLatitude = this.boundingBox[2],
                                   EastLongitude = this.boundingBox[3]
                               };
                }

                return null;
            }
        }

        /// <summary>
        /// Gets or sets the confidence.
        /// </summary>
        /// <value>
        /// The confidence.
        /// </value>
        [JsonProperty("confidence")]
        [JsonConverter(typeof(StringEnumConverter))]
        public GeocodeConfidence Confidence { get; set; }

        /// <summary>
        /// Gets the geocode points.
        /// </summary>
        /// <value>
        /// The geocode points.
        /// </value>
        [JsonProperty("geocodePoints")]
        public Coordinates[] GeocodePoints { get; internal set; }

        /// <summary>
        /// Gets the display point.
        /// </summary>
        public ICoordinates DisplayPoint
        {
            get
            {
                return this.GeocodePoints.FirstOrDefault(x => x.UsageTypes.Contains(GeocodeUsageType.Display));
            }
        }

        /// <summary>
        /// Gets the route point.
        /// </summary>
        public ICoordinates RoutePoint
        {
            get
            {
                return this.GeocodePoints.FirstOrDefault(x => x.UsageTypes.Contains(GeocodeUsageType.Route));
            }
        }

        /// <summary>
        /// Gets the match codes.
        /// </summary>
        /// <value>
        /// The match codes.
        /// </value>
        public GeocodeMatchCode[] MatchCodes
        {
            get
            {
                return this.matchCodes.Select(x => (GeocodeMatchCode)Enum.Parse(typeof(GeocodeMatchCode), x)).ToArray();
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        [JsonProperty("name")]
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1632:DocumentationTextMustMeetMinimumCharacterLength", Justification = "Reviewed. Suppression is OK here.")]
        public string Name { get; internal set; }

        /// <summary>
        /// Gets the point.
        /// </summary>
        /// <value>
        /// The point.
        /// </value>
        [JsonProperty("point")]
        public ICoordinates Point { get; internal set; }

        /// <summary>
        /// Gets the entity type.
        /// </summary>
        [JsonProperty("entityType")]
        public string EntityType { get; internal set; }
    }
}