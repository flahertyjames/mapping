// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Icon.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Image object for the POI.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest.Javascript
{
    /// <summary>
    /// Image object for the POI.
    /// </summary>
    public class Icon : MapQuestObject
    {
        private const int DefaultHeight = 29;
        private const int DefaultWidth = 20;

        /// <summary>
        /// Initializes a new instance of the <see cref="Icon"/> class.
        /// </summary>
        public Icon()
        {
            this.Height = DefaultHeight;
            this.Width = DefaultWidth;
        }

        /// <summary>
        /// Gets or sets the url.
        /// </summary>
        public string Url { get; set; }

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
        /// Gets or sets the index.
        /// </summary>
        public int? Index { get; set; }
    }
}
