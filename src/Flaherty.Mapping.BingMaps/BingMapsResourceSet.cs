// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BingMapsResourceSet.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The Bing maps resource set.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using System.Collections.Generic;

    using Flaherty.Services;

    using Newtonsoft.Json;

    /// <summary>
    /// The Bing maps resource set.
    /// </summary>
    /// <typeparam name="TResponse">
    /// The response type.
    /// </typeparam>
    public class BingMapsResourceSet<TResponse>
        where TResponse : IResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BingMapsResourceSet{TResponse}"/> class.
        /// </summary>
        public BingMapsResourceSet()
        {
            this.Resources = new List<TResponse>();
        }

        /// <summary>
        /// Gets or sets the estimated total.
        /// </summary>
        /// <value>
        /// The estimated total.
        /// </value>
        [JsonProperty("estimatedTotal")]
        public string EstimatedTotal { get; set; }

        /// <summary>
        /// Gets or sets the resources.
        /// </summary>
        /// <value>
        /// The resources.
        /// </value>
        [JsonProperty("resources")]
        public List<TResponse> Resources { get; set; } 
    }
}
