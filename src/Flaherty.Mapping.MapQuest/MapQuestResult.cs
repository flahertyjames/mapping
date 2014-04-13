// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapQuestResult.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The MapQuest result.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using System.Collections.Generic;

    using Newtonsoft.Json;

    /// <summary>
    /// The MapQuest result.
    /// </summary>
    public class MapQuestResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapQuestResult"/> class.
        /// </summary>
        public MapQuestResult()
        {
            this.Locations = new List<Location>();
        }

        /// <summary>
        /// Gets or sets the locations.
        /// </summary>
        [JsonProperty("locations")]
        public List<Location> Locations { get; set; } 
    }
}
