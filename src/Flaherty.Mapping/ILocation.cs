// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILocation.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping
{
    /// <summary>
    /// The location interface.
    /// </summary>
    public interface ILocation
    {
        /// <summary>
        /// Gets the address.
        /// </summary>
        IAddress Address { get; }

        /// <summary>
        /// Gets the point.
        /// </summary>
        ICoordinates Point { get; }

        /// <summary>
        /// Gets the display point.
        /// </summary>
        ICoordinates DisplayPoint { get; }

        /// <summary>
        /// Gets the route point.
        /// </summary>
        ICoordinates RoutePoint { get; }

        /// <summary>
        /// Gets the boundary.
        /// </summary>
        IBoundary Boundary { get; }
    }
}
