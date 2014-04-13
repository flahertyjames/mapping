// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Location.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location response.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
{
    using System;

    using Flaherty.Mapping.MapQuest.Json;
    using Flaherty.Services;

    using Newtonsoft.Json;

    /// <summary>
    /// The location response.
    /// </summary>
    public class Location : ILocation, IResponse
    {
        // ReSharper disable UnassignedField.Compiler
        [JsonProperty]
        private string adminArea1;

        [JsonProperty]
        private string adminArea1Type;

        [JsonProperty]
        private string adminArea2;

        [JsonProperty]
        private string adminArea2Type;

        [JsonProperty]
        private string adminArea3;

        [JsonProperty]
        private string adminArea3Type;

        [JsonProperty]
        private string adminArea4;

        [JsonProperty]
        private string adminArea4Type;

        [JsonProperty]
        private string adminArea5;

        [JsonProperty]
        private string adminArea5Type;

        [JsonProperty]
        private string street;

        [JsonProperty]
        private string postalCode;

        [JsonProperty]
        private SideOfStreet sideOfStreet;

        private IAddress address;
        // ReSharper restore UnassignedField.Compiler

        /// <summary>
        /// Initializes a new instance of the <see cref="Location"/> class.
        /// </summary>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <param name="displayPoint">
        /// The display point.
        /// </param>
        public Location(Coordinates point, Coordinates displayPoint)
        {
            this.Point = point;
            this.DisplayPoint = displayPoint;
        }

        /// <summary>
        /// Gets the address.
        /// </summary>
        public IAddress Address
        {
            get
            {
                if (this.address == null)
                {
                    this.address = new Address
                                       {
                                           Street = this.street,
                                           Locality = this.adminArea5,
                                           LocalityLabel = this.adminArea5Type,
                                           AdministrativeArea2 = this.adminArea4,
                                           AdministrativeArea2Label = this.adminArea4Type,
                                           AdministrativeArea = this.adminArea3,
                                           AdministrativeAreaLabel = this.adminArea3Type,
                                           Country = this.adminArea1,
                                           CountryLabel = this.adminArea1Type,
                                           PostalCode = this.postalCode,
                                           SideOfStreet = this.sideOfStreet
                                       };
                }

                return this.address;
            }
        }

        /// <summary>
        /// Gets the boundary.
        /// </summary>
        public IBoundary Boundary
        {
            get
            {
                throw new NotSupportedException();
            }
        }

        /// <summary>
        /// Gets the display point.
        /// </summary>
        [JsonProperty("displayLatLng")]
        [JsonConverter(typeof(PointConverter))]
        public ICoordinates DisplayPoint { get; internal set; }

        /// <summary>
        /// Gets the route point.
        /// </summary>
        public ICoordinates RoutePoint
        {
            get
            {
                return this.Point;
            }
        }

        /// <summary>
        /// Gets the point.
        /// </summary>
        /// <value>
        /// The point.
        /// </value>
        [JsonProperty("latLng")]
        [JsonConverter(typeof(PointConverter))]
        public ICoordinates Point { get; internal set; }
    }
}