// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ILocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The LocationRequest interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping
{
    using Flaherty.Services;

    /// <summary>
    /// The LocationRequest interface.
    /// </summary>
    public interface ILocationRequest : IParameters
    {
        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        string Key { get; set; }
    }
}
