// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocateOptions.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The locate options.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    /// <summary>
    /// The locate options.
    /// </summary>
    public class LocateOptions : ILocateOptions
    {
        /// <summary>
        /// Gets or sets the include neighborhood.
        /// </summary>
        /// <value>
        /// The include neighborhood.
        /// </value>
        public bool? IncludeNeighborhood { get; set; }

        /// <summary>
        /// Gets or sets the include.
        /// </summary>
        /// <value>
        /// The include.
        /// </value>
        public string Include { get; set; }
    }
}
