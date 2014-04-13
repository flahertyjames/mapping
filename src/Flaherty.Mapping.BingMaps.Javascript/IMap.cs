// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMap.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The map interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    /// <summary>
    /// The map interface.
    /// </summary>
    public interface IMap : Mapping.Javascript.IMap<Boundary, Coordinates, MapType, Pin>
    {
        /// <summary>
        /// Gets or sets a value indicating whether load the Bing theme.
        /// </summary>
        bool LoadBingTheme { get; set; }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        MapOptions Options { get; set; }
    }
}
