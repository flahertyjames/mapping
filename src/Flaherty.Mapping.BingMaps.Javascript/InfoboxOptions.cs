// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InfoboxOptions.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Represents the options for an info box.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System.ComponentModel;

    using Flaherty.Mapping.BingMaps.Javascript.Json;

    using Newtonsoft.Json;

    /// <summary>
    /// Represents the options for an info box.
    /// </summary>
    public class InfoboxOptions
    {
        /// <summary>
        /// Gets or sets the string displayed inside the info box.
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the height of the pushpin, which is the height of the pushpin icon. The default value is 39.
        /// </summary>
        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public int? Height { get; set; }

        /// <summary>
        /// Gets or sets the HTML that represents the info box. Note that info box options are ignored if custom HTML 
        /// is set. Also, if custom HTML is used to represent the info box, the info box is anchored at the top-left 
        /// corner.
        /// </summary>
        [JsonProperty("htmlContent", NullValueHandling = NullValueHandling.Ignore)]
        public string HtmlContent { get; set; }

        /// <summary>
        /// Gets or sets the ID associated with the info box.
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the amount the info box pointer is shifted from the location of the info box, or if 
        /// showPointer is false, then it is the amount the info box bottom left edge is shifted from the location of 
        /// the info box. If custom HTML is set, it is the amount the top-left corner of the info box is shifted from 
        /// its location. The default offset value is (0,0), which means there is no offset.
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        [TypeConverter(typeof(PointConverter))]
        public Point Offset { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether to show the close dialog button on the info box. The default 
        /// value is true. By default the close button is displayed as an X in the top right corner of the info box.
        /// This property is ignored if custom HTML is used to represent the info box.
        /// </summary>
        [JsonProperty("showCloseButton", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCloseButton { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether to display the info box with a pointer. The default value is 
        /// true. In this case the info box is anchored at the bottom point of the pointer. If this property is set 
        /// to false, the info box is anchored at the bottom left corner.
        /// This property is ignored if custom HTML is used to represent the info box.
        /// </summary>
        [JsonProperty("showPointer", NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowPointer { get; set; }
        
        /// <summary>
        /// Gets or sets the title of the info box.
        /// </summary>
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a boolean indicating whether to show or hide the info box. The default value is true. A 
        /// value of false indicates that the info box is hidden, although it is still an entity on the map.
        /// </summary>
        [JsonProperty("visible", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Gets or sets the width of the info box. The default value is 256.
        /// </summary>
        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets the z-index of the info box with respect to other items on the map.
        /// </summary>
        [JsonProperty("zIndex", NullValueHandling = NullValueHandling.Ignore)]
        public int? ZIndex { get; set; }
    }
}
