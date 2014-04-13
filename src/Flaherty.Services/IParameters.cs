// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IParameters.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The Parameters interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Services
{
    /// <summary>
    /// The Parameters interface.
    /// </summary>
    public interface IParameters : IRequest
    {
        /// <summary>
        /// Generates a parameter string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        string ToParameterString();
    }
}
