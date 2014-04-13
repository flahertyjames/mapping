// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapType.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Contains identifiers for the imagery displayed on the map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System.Diagnostics.CodeAnalysis;

    using Flaherty.Mapping.BingMaps.Javascript.Json;

    using Newtonsoft.Json;

    /// <summary>
    /// Contains identifiers for the imagery displayed on the map.
    /// </summary>
    [JsonConverter(typeof(MapTypeConverter))]
    public enum MapType
    {
        /// <summary>
        /// The aerial map type is being used.
        /// </summary>
        Aerial,

        /// <summary>
        /// The map is set to choose the best imagery for the current view.
        /// </summary>
        Auto,

        /// <summary>
        /// The bird’s eye map type is being used.
        /// </summary>
        BirdsEye,

        /// <summary>
        /// Collin’s Bart (mkt=en-gb) map type is being used.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        CollinsBart,

        /// <summary>
        /// The Mercator map type is being used. This setting removes the base map tiles.
        /// </summary>
        Mercator,

        /// <summary>
        /// Ordnance Survey (mkt=en-gb) map type is being used.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed. Suppression is OK here.")]
        OrdnanceSurvey,

        /// <summary>
        /// The road map type is being used.
        /// </summary>
        Road
    }
}