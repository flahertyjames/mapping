// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeocodeConfidence.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The confidence level of the geocoded point.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    /// <summary>
    /// The confidence level of the geocoded point.
    /// </summary>
    public enum GeocodeConfidence
    {
        /// <summary>
        /// High confidence.
        /// </summary>
        High,

        /// <summary>
        /// Medium confidence.
        /// </summary>
        Medium,

        /// <summary>
        /// Low confidence.
        /// </summary>
        Low
    }
}
