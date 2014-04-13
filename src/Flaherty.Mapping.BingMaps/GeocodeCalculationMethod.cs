// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GeocodeCalculationMethod.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The calculation method used to compute the geocode point.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    /// <summary>
    /// The calculation method used to compute the geocode point.
    /// </summary>
    public enum GeocodeCalculationMethod
    {
        /// <summary>
        /// The geocode point was matched to a point on a road using interpolation.
        /// </summary>
        Interpolation,

        /// <summary>
        /// The geocode point was matched to a point on a road using interpolation 
        /// with an additional offset to shift the point to the side of the street.
        /// </summary>
        InterpolationOffset,

        /// <summary>
        /// The geocode point was matched to the center of a parcel.
        /// </summary>
        Parcel,

        /// <summary>
        /// The geocode point was matched to the rooftop of a building.
        /// </summary>
        Rooftop
    }
}
