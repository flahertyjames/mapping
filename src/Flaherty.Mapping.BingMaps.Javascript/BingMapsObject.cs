// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BingMapsObject.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Abstract base class for Bing Maps objects.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    /// <summary>
    /// Abstract base class for Bing Maps objects.
    /// </summary>
    public abstract class BingMapsObject
    {
        /// <summary>
        /// Gets the JavaScript type name.
        /// </summary>
        internal virtual string JavascriptTypeName
        {
            get
            {
                return string.Format("Microsoft.Maps.{0}", this.GetType().Name);
            }
        }

        /// <summary>
        /// Returns the JavaScript representation of the object.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        internal virtual string ToJavascript()
        {
            return string.Format("new {0}({1})", this.JavascriptTypeName, this);
        }
    }
}
