// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Point.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The point.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps.Javascript
{
    using System;

    using Flaherty.Mapping.Javascript;

    /// <summary>
    /// The point.
    /// </summary>
    public class Point : BingMapsObject, IPoint
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> class.
        /// </summary>
        /// <param name="x">
        /// The x value.
        /// </param>
        /// <param name="y">
        /// The y value.
        /// </param>
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or sets the x value.
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Gets or sets the y value.
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Parses a string into a new point.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        /// <returns>
        /// The <see cref="Boundary"/>.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Thrown when provided point is not in the correct format.
        /// </exception>
        public static Point Parse(string value)
        {
            var point = value.Split(',');
            double x, y;
            if (point.Length != 2 || !double.TryParse(point[0].Trim(), out x) || !double.TryParse(point[1].Trim(), out y))
            {
                throw new ArgumentException("Provided point is not in the correct format.");
            }

            return new Point(x, y);
        }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("{0},{1}", this.X, this.Y);
        }
    }
}
