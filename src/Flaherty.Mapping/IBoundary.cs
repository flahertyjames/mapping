// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IBoundary.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The boundary interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping
{
    /// <summary>
    /// The boundary interface.
    /// </summary>
    public interface IBoundary
    {
        /// <summary>
        /// Gets or sets the south latitude.
        /// </summary>
        double SouthLatitude { get; set; }

        /// <summary>
        /// Gets or sets the west longitude.
        /// </summary>
        double WestLongitude { get; set; }

        /// <summary>
        /// Gets or sets the north latitude.
        /// </summary>
        double NorthLatitude { get; set; }

        /// <summary>
        /// Gets or sets the east longitude.
        /// </summary>
        double EastLongitude { get; set; }
    }
}
