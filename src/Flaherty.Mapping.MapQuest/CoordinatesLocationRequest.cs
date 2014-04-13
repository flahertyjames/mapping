// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CoordinatesLocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The coordinates location request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using Flaherty.Services;

    /// <summary>
    /// The coordinates location request.
    /// </summary>
    public class CoordinatesLocationRequest : LocationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CoordinatesLocationRequest"/> class.
        /// </summary>
        public CoordinatesLocationRequest()
        {
            this.Method = "reverse";
        }

        /// <summary>
        /// Gets the point.
        /// </summary>
        [Parameter("location")]
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