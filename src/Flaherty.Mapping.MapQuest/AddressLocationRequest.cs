// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressLocationRequest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location request.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using Flaherty.Services;

    /// <summary>
    /// The location request.
    /// </summary>
    public class AddressLocationRequest : LocationRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressLocationRequest"/> class.
        /// </summary>
        public AddressLocationRequest()
        {
            this.Method = "address";
        }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        [Parameter("state")]
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        [Parameter("city")]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        [Parameter("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or sets the street.
        /// </summary>
        [Parameter("street")]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        [Parameter("country")]
        public string Country { get; set; }
    }
}
