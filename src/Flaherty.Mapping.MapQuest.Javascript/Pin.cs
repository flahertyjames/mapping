// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pin.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Defines a pushpin on the map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript
{
    using System.ComponentModel;

    using Flaherty.Mapping.Javascript;
    using Flaherty.Mapping.MapQuest.Javascript.Converters;

    /// <summary>
    /// Defines a pushpin on the map.
    /// </summary>
    public class Pin : MapQuestObject,  IPin<Coordinates>
    {
        private const int DefaultHeight = 29;
        private const int DefaultWidth = 20;

        /// <summary>
        /// Initializes a new instance of the <see cref="Pin"/> class.
        /// </summary>
        public Pin()
        {
            this.Height = DefaultHeight;
            this.Width = DefaultWidth;
        }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [TypeConverter(typeof(CoordinatesConverter))]
        public virtual Coordinates Position { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        public virtual string Icon { get; set; }

        /// <summary>
        /// Gets or sets the height.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the width.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Gets or sets the color.
        /// </summary>
        public PinColor? Color { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public virtual string Text { get; set; }

        /// <summary>
        /// Gets or sets the info text.
        /// </summary>
        public virtual string InfoText { get; set; }

        /// <summary>
        /// Gets the JavaScript type name.
        /// </summary>
        internal override string JavascriptTypeName
        {
            get
            {
                return "MQA.Poi";
            }
        }
    }
}
