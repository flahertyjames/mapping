// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LabelOverlay.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   Defines how map labels are displayed.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using Flaherty.Mapping.BingMaps.Javascript.Json;

    using Newtonsoft.Json;

    /// <summary>
    /// Defines how map labels are displayed.
    /// </summary>
    [JsonConverter(typeof(LabelOverlayConverter))]
    public enum LabelOverlay
    {
        /// <summary>
        /// Map labels are not shown on top of imagery.
        /// </summary>
        Hidden,

        /// <summary>
        /// Map labels are shown on top of imagery.
        /// </summary>
        Visible
    }
}
