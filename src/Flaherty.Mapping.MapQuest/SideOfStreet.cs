// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SideOfStreet.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The side of street.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using Flaherty.Mapping.MapQuest.Json;

    using Newtonsoft.Json;

    /// <summary>
    /// The side of street.
    /// </summary>
    [JsonConverter(typeof(SideOfStreetConverter))]
    public enum SideOfStreet
    {
        /// <summary>
        /// The left.
        /// </summary>
        Left,

        /// <summary>
        /// The right.
        /// </summary>
        Right,

        /// <summary>
        /// The none.
        /// </summary>
        None
    }
}
