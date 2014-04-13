// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICoordinates.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The coordinates interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping
{
    /// <summary>
    /// The coordinates interface.
    /// </summary>
    public interface ICoordinates
    {
        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        double Longitude { get; set; }
    }
}
