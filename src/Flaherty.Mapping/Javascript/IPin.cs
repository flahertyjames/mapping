// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IPin.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The Pin interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.Javascript
{
    /// <summary>
    /// The Pin interface.
    /// </summary>
    public interface IPin
    {
    }

    /// <summary>
    /// The Pin interface.
    /// </summary>
    /// <typeparam name="TCoordinates">
    /// The coordinates type.
    /// </typeparam>
    public interface IPin<TCoordinates> : IPin
        where TCoordinates : ICoordinates
    {
        /// <summary>
        /// Gets or sets the position.
        /// </summary>
        TCoordinates Position { get; set; }

        /// <summary>
        /// Gets or sets the icon.
        /// </summary>
        string Icon { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// Gets or sets the info text.
        /// </summary>
        string InfoText { get; set; }
    }
}
