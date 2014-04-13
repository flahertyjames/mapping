// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryLocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The query location request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using Flaherty.Services;

    /// <summary>
    /// The query location request.
    /// </summary>
    public class QueryLocationRequest : LocationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryLocationRequest"/> class.
        /// </summary>
        public QueryLocationRequest()
        {
            this.Method = "address";
        }

        /// <summary>
        /// Gets or sets the query.
        /// </summary>
        [Parameter("location")]
        public string Query { get; set; }
    }
}