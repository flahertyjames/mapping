// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The abstract location request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using System.ComponentModel;

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
        /// Gets or sets the include neighborhood.
        /// </summary>
        /// <value>
        /// The include neighborhood.
        /// </value>
        [Parameter("inclnb")]
        [ParameterConverter(typeof(Int32Converter))]
        public bool? IncludeNeighborhood { get; set; }

        /// <summary>
        /// Gets or sets the include.
        /// </summary>
        /// <value>
        /// The include.
        /// </value>
        [Parameter("incl")]
        public string Include { get; set; }

        /// <summary>
        /// Gets or sets the max results.
        /// </summary>
        /// <value>
        /// The max results.
        /// </value>
        [Parameter("maxRes")]
        public int? MaxResults { get; set; }
    }
}