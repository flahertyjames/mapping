// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Infobox.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Represents an info box on the map. You can use this class to create pop-up balloons for pushpins.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    /// <summary>
    /// Represents an info box on the map. You can use this class to create pop-up balloons for pushpins.
    /// </summary>
    public class Infobox : BingMapsObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Infobox"/> class.
        /// </summary>
        public Infobox()
        {
            // ReSharper disable once DoNotCallOverridableMethodsInConstructor
            this.Options = new InfoboxOptions();
        }

        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        public virtual Coordinates Location { get; set; }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        public virtual InfoboxOptions Options { get; set; }

        /// <summary>
        /// Returns a boolean value indicating whether the info box essentially contains no display data.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool IsEmpty()
        {
            return string.IsNullOrEmpty(this.Options.Title) && string.IsNullOrEmpty(this.Options.HtmlContent);
        }
    }
}
