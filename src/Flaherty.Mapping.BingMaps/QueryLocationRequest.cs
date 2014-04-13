// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryLocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The query location request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using Flaherty.Services;

    /// <summary>
    /// The query location request.
    /// </summary>
    public class QueryLocationRequest : LocationRequest
    {
        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        [Parameter("q")]
        public string Query { get; set; }
    }
}