// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapTypeConverter.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Converts a map type to JSON.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript.Json
{
    /// <summary>
    /// Converts a map type to JSON.
    /// </summary>
    public class MapTypeConverter : EnumConverter<MapType>
    {
        /// <summary>
        /// Gets the Microsoft Maps type name.
        /// </summary>
        protected override string TypeName
        {
            get
            {
                return base.TypeName + "Id";
            }
        }
    }
}