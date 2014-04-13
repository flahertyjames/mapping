// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Coordinates.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The coordinates.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using Newtonsoft.Json;

    /// <summary>
    /// The coordinates.
    /// </summary>
    public class Coordinates : ICoordinates
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [JsonProperty("lng")]
        public double Longitude { get; set; }
    }
}