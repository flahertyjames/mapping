// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BingMapsResponse.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The bing maps response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using System.Collections.Generic;

    using Flaherty.Services;

    using Newtonsoft.Json;

    /// <summary>
    /// The bing maps response.
    /// </summary>
    /// <typeparam name="TResponse">
    /// The response type.
    /// </typeparam>
    public class BingMapsResponse<TResponse>
        where TResponse : IResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BingMapsResponse{TResponse}"/> class.
        /// </summary>
        public BingMapsResponse()
        {
            this.ResourceSets = new List<BingMapsResourceSet<TResponse>>();
        }

        /// <summary>
        /// Gets or sets the authentication result code.
        /// </summary>
        /// <value>
        /// The authentication response code.
        /// </value>
        [JsonProperty("authenticationResultCode")]
        public string AuthenticationResultCode { get; set; }

        /// <summary>
        /// Gets or sets the brand logo URI.
        /// </summary>
        /// <value>
        /// The brand logo URI.
        /// </value>
        [JsonProperty("brandLogoUri")]
        public string BrandLogoUri { get; set; }

        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        /// <value>
        /// The copyright.
        /// </value>
        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the status code.
        /// </summary>
        /// <value>
        /// The status code.
        /// </value>
        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        /// <summary>
        /// Gets or sets the status description.
        /// </summary>
        /// <value>
        /// The status description.
        /// </value>
        [JsonProperty("statusDescription")]
        public string StatusDescription { get; set; }

        /// <summary>
        /// Gets or sets the trace id.
        /// </summary>
        /// <value>
        /// The trace id.
        /// </value>
        [JsonProperty("traceId")]
        public string TraceId { get; set; }

        /// <summary>
        /// Gets or sets the resource sets.
        /// </summary>
        [JsonProperty("resourceSets")]
        public List<BingMapsResourceSet<TResponse>> ResourceSets { get; set; } 
    }
}
