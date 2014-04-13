// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapType.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Contains identifiers for the imagery displayed on the map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript
{
    using Flaherty.Mapping.MapQuest.Javascript.Json;

    using Newtonsoft.Json;

    /// <summary>
    /// Contains identifiers for the imagery displayed on the map.
    /// </summary>
    [JsonConverter(typeof(MapTypeConverter))]
    public enum MapType
    {
        /// <summary>
        /// The map type is being used.
        /// </summary>
        Map,

        /// <summary>
        /// The open street map type is being used.
        /// </summary>
        OpenStreetMap,

        /// <summary>
        /// The satellite type is being used.
        /// </summary>
        Satellite,

        /// <summary>
        /// The hybrid type is being used.
        /// </summary>
        Hybrid
    }
}