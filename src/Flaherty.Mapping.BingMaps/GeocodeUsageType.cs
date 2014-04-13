// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeocodeUsageType.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The best use for the geocode point.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    /// <summary>
    /// The best use for the geocode point.
    /// </summary>
    public enum GeocodeUsageType
    {
        /// <summary>
        /// Best for display of a location on a map.
        /// </summary>
        Display,

        /// <summary>
        /// Best when calcuating a point in a route.
        /// </summary>
        Route
    }
}
