// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMap.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The Map interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.Javascript
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The Map interface.
    /// </summary>
    public interface IMap
    {
        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        string ApiKey { get; set; }
    }

    /// <summary>
    /// The Map interface.
    /// </summary>
    /// <typeparam name="TBoundary">
    /// The boundary type.
    /// </typeparam>
    /// <typeparam name="TCoordinates">
    /// The coordinates type.
    /// </typeparam>
    /// <typeparam name="TMapType">
    /// The map type.
    /// </typeparam>
    /// <typeparam name="TPin">
    /// The pin type.
    /// </typeparam>
    public interface IMap<TBoundary, TCoordinates, TMapType, TPin> : IMap
        where TBoundary : IBoundary
        where TCoordinates : ICoordinates
        where TMapType : struct, IConvertible
        where TPin : IPin
    {
        /// <summary>
        /// Gets or sets a value indicating whether to set the boundary by the pins.
        /// </summary>
        bool AutomaticBoundary { get; set; }

        /// <summary>
        /// Gets or sets the boundary.
        /// </summary>
        TBoundary Boundary { get; set; }

        /// <summary>
        /// Gets or sets the center.
        /// </summary>
        TCoordinates Center { get; set; }

        /// <summary>
        /// Gets or sets the map type.
        /// </summary>
        TMapType? MapType { get; set; }

        /// <summary>
        /// Gets or sets the padding.
        /// </summary>
        double? Padding { get; set; }

        /// <summary>
        /// Gets the pins.
        /// </summary>
        List<TPin> Pins { get; }

        /// <summary>
        /// Gets or sets the show map type control.
        /// </summary>
        bool? ShowMapTypeControl { get; set; }

        /// <summary>
        /// Gets or sets the show pan control.
        /// </summary>
        bool? ShowPanControl { get; set; }

        /// <summary>
        /// Gets or sets the show zoom control.
        /// </summary>
        bool? ShowZoomControl { get; set; }

        /// <summary>
        /// Gets the target ID.
        /// </summary>
        string Target { get; }

        /// <summary>
        /// Gets or sets the zoom.
        /// </summary>
        int? Zoom { get; set; }
    }
}
