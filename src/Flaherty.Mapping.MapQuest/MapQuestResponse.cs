// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapQuestResponse.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The MapQuest response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The MapQuest response.
    /// </summary>
    public class MapQuestResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapQuestResponse"/> class.
        /// </summary>
        public MapQuestResponse()
        {
            this.Results = new List<MapQuestResult>();
        }

        /// <summary>
        /// Gets or sets the results.
        /// </summary>
        [JsonProperty("results")]
        public List<MapQuestResult> Results { get; set; } 
    }
}
