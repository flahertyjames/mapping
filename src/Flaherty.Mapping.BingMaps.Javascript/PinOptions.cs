// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PinOptions.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Represents the options for a pushpin.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System.ComponentModel;

    using Flaherty.Mapping.BingMaps.Javascript.Converters;

    using Newtonsoft.Json;

    /// <summary>
    /// Represents the options for a pushpin.
    /// </summary>
    public class PinOptions
    {
        /// <summary>
        /// Gets or sets the point on the pushpin icon which is anchored to the pushpin location. An anchor of (0,0) 
        /// is the top left corner of the icon. The default anchor is the bottom center of the icon.
        /// </summary>
        [JsonProperty("anchor", NullValueHandling = NullValueHandling.Ignore)]
        [TypeConverter(typeof(PointConverter))]
        public Point Anchor { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether the pushpin can be dragged to a new position with the mouse.
        /// </summary>
        [JsonProperty("draggable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Draggable { get; set; }

        /// <summary>
        /// Gets or sets the height of the pushpin, which is the height of the pushpin icon. The default value is 39.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the HTML that represents the pushpin.
        /// </summary>
        [JsonProperty("htmlContent", NullValueHandling = NullValueHandling.Ignore)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// Gets or sets the path of the image to use as the pushpin icon.
        /// </summary>
        [JsonProperty("icon", NullValueHandling = NullValueHandling.Ignore)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or sets the info box associated with this pushpin.
        /// </summary>
        [JsonIgnore]
        public Infobox Infobox { get; set; }

        //// <summary>
        //// Gets or sets the state of the pushpin, such as highlighted or selected.
        //// </summary>
        ////[JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        ////public EntityState State { get; set; }

        /// <summary>
        /// Gets or sets the text associated with the pushpin.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the amount the text is shifted from the pushpin icon. The default value is (0,5).
        /// </summary>
        [JsonProperty("textOffset", NullValueHandling = NullValueHandling.Ignore)]
        [TypeConverter(typeof(PointConverter))]
        public Point TextOffset { get; set; }

        /// <summary>
        /// Gets or sets the type of the pushpin, as a string. The pushpin DOM (document object model) node created 
        /// for the pushpin will have the specified typeName. A standard pushpin type is used unless the 
        /// Microsoft.Maps.Themes.BingTheme module is loaded, in which case typeName can be set to ‘micro’ to use 
        /// the micro pushpin type.
        /// </summary>
        [JsonProperty("typeName", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeName { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether to show or hide the pushpin. The default value is true. A value 
        /// of false indicates that the pushpin is hidden, although it is still an entity on the map.
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Gets or sets the width of the pushpin, which is the width of the pushpin icon. The default value is 25.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the z-index of the pushpin with respect to other items on the map.
        /// </summary>
        [JsonProperty("zIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? ZIndex { get; set; }
    }
}
