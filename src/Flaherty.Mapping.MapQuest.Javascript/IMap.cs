// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMap.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The map interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript
{
    /// <summary>
    /// The map interface.
    /// </summary>
    public interface IMap : Mapping.Javascript.IMap<Boundary, Coordinates, MapType, Pin>
    {
        /// <summary>
        /// Gets or sets the license.
        /// </summary>
        License License { get; set; }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        MapOptions Options { get; set; }
    }
}
