// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapOptions.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The map options.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript
{
    using Flaherty.Mapping.MapQuest.Javascript.Json;

    using Newtonsoft.Json;

    /// <summary>
    /// The map options.
    /// </summary>
    public class MapOptions
    {
        /// <summary>
        /// Gets or sets the element.
        /// </summary>
        [JsonProperty("elt", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(ElementConverter))]
        public string Element { get; set; }

        /// <summary>
        /// Gets or sets the center of map in latitude/longitude.
        /// </summary>
        [JsonProperty("latLng", NullValueHandling = NullValueHandling.Ignore)]
        public Coordinates Center { get; set; }

        /// <summary>
        /// Gets or sets the label overlay of the view.
        /// </summary>
        [JsonProperty("mtype", NullValueHandling = NullValueHandling.Ignore)]
        public MapType? MapType { get; set; }

        /// <summary>
        /// Gets or sets the margin offset from the map viewport when applying a best fit on shapes.
        /// </summary>
        [JsonProperty("bestFitMargin", NullValueHandling = NullValueHandling.Ignore)]
        public double? Padding { get; set; }

        /// <summary>
        /// Gets or sets the zoom level of the map view.
        /// </summary>
        [JsonProperty("zoom", NullValueHandling = NullValueHandling.Ignore)]
        public int? Zoom { get; set; }
    }
}
