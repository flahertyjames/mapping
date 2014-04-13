// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoordinatesLocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The coordinates location request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using Flaherty.Services;

    /// <summary>
    /// The coordinates location request.
    /// </summary>
    public class CoordinatesLocationRequest : LocationRequest
    {
        /// <summary>
        /// Gets the point.
        /// </summary>
        [Parameter("q")]
        public string Point
        {
            get
            {
                return string.Format("{0},{1}", this.Latitude, this.Longitude);
            }
        }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        [ParameterIgnore]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        [ParameterIgnore]
        public double Longitude { get; set; }
    }
}