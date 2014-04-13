// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Boundary.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   A geographic area that contains a location.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    /// <summary>
    /// A geographic area that contains a location.
    /// </summary>
    public class Boundary : IBoundary
    {
        /// <summary>
        /// Gets or sets the south latitude.
        /// </summary>
        public double SouthLatitude { get; set; }

        /// <summary>
        /// Gets or sets the west longitude.
        /// </summary>
        public double WestLongitude { get; set; }

        /// <summary>
        /// Gets or sets the north latitude.
        /// </summary>
        public double NorthLatitude { get; set; }

        /// <summary>
        /// Gets or sets the east longitude.
        /// </summary>
        public double EastLongitude { get; set; }
    }
}
