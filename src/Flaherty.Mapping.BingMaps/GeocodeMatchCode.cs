// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeocodeMatchCode.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Value that represents the geocoding level for a location.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    /// <summary>
    /// Value that represents the geocoding level for a location.
    /// </summary>
    public enum GeocodeMatchCode
    {
        /// <summary>
        /// The location has only one match or all returned matches are considered strong matches.
        /// </summary>
        Good,

        /// <summary>
        /// The location is one of a set of possible matches.
        /// </summary>
        Ambiguous,

        /// <summary>
        /// The location represents a move up the geographic hierarchy.
        /// </summary>
        UpHierarchy
    }
}
