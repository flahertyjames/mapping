// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Pin.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Defines a pushpin on the map.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System.ComponentModel;

    using Flaherty.Mapping.BingMaps.Javascript.Converters;
    using Flaherty.Mapping.Javascript;

    /// <summary>
    /// Defines a pushpin on the map.
    /// </summary>
    public class Pin : BingMapsObject, IPin<Coordinates>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pin"/> class.
        /// </summary>
        public Pin()
        {
            // ReSharper disable once DoNotCallOverridableMethodsInConstructor
            this.Options = new PinOptions();
        }

        /// <summary>
        /// Gets or sets the options.
        /// </summary>
        public virtual PinOptions Options { get; set; }

        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        [TypeConverter(typeof(CoordinatesConverter))]
        public virtual Coordinates Position { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        public virtual string Icon
        {
            get
            {
                return this.Options.Icon;
            }

            set
            {
                this.Options.Icon = value;
            }
        }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        public virtual string Text
        {
            get
            {
                return this.Options.Text;
            }

            set
            {
                this.Options.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the info text.
        /// </summary>
        public virtual string InfoText
        {
            get
            {
                return (this.Options.Infobox != null) ? this.Options.Infobox.Options.Title : null;
            }

            set
            {
                if (this.Options.Infobox == null)
                {
                    this.Options.Infobox = new Infobox();
                }

                this.Options.Infobox.Options.Title = value;
            }
        }

        /// <summary>
        /// Gets the JavaScript type name.
        /// </summary>
        internal override string JavascriptTypeName
        {
            get
            {
                return "Microsoft.Maps.Pushpin";
            }
        }
    }
}
