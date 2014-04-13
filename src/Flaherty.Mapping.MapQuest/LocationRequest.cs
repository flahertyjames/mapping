// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The abstract location request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using Flaherty.Services;

    /// <summary>
    /// The abstract location request.
    /// </summary>
    public abstract class LocationRequest : Parameters, ILocationRequest
    {
        /// <summary>
        /// Gets or sets the API key.
        /// </summary>
        [Parameter("key", UrlEncode = false)]
        public string Key { get; set; }

        /// <summary>
        /// Gets the method.
        /// </summary>
        [ParameterIgnore]
        public string Method { get; internal set; }

        /// <summary>
        /// Gets or sets the max results.
        /// </summary>
        [Parameter("maxRes")]
        public int? MaxResults { get; set; }
    }
}