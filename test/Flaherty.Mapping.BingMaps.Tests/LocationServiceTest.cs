// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationServiceTest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location service test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.BingMaps
{
    using System.Configuration;

    using NUnit.Framework;

    /// <summary>
    /// The location service test.
    /// </summary>
    [TestFixture]
    public class LocationServiceTest
    {
        private LocationService service;

        /// <summary>
        /// Sets up the test.
        /// </summary>
        [SetUp]
        public void SetUp()
        {
            this.service = new LocationService(ConfigurationManager.AppSettings["apikey"]);
        }

        /// <summary>
        /// Tests retrieval of a location by an address.
        /// </summary>
        [Test]
        // ReSharper disable once InconsistentNaming
        public void LocationService_LocateFromAddress_ReturnsData()
        {
            var location = this.service.Locate("US", "WA", "98052", "Redmond", "1 Microsoft Way");
            Assert.IsNotNull(location);
            Assert.AreEqual("United States", location.Address.Country);
            Assert.AreEqual("WA", location.Address.AdministrativeArea);
            Assert.AreEqual("98052", location.Address.PostalCode);
            Assert.AreEqual("Redmond", location.Address.Locality);
        }

        /// <summary>
        /// Tests retrieval of a location from a query.
        /// </summary>
        [Test]
        // ReSharper disable once InconsistentNaming
        public void LocationService_LocateFromQuery_ReturnsData()
        {
            var location = this.service.Locate("1 Microsoft Way, Redmond, WA 98052");
            Assert.IsNotNull(location);
            Assert.AreEqual("United States", location.Address.Country);
            Assert.AreEqual("WA", location.Address.AdministrativeArea);
            Assert.AreEqual("98052", location.Address.PostalCode);
            Assert.AreEqual("Redmond", location.Address.Locality);
        }

        /// <summary>
        /// Tests retrieval of a location by a point.
        /// </summary>
        [Test]
        // ReSharper disable once InconsistentNaming
        public void LocationService_LocateFromPoint_ReturnsData()
        {
            var location = this.service.Locate(47.64054, -122.12934);
            Assert.IsNotNull(location);
            Assert.AreEqual(47.64054, location.Point.Latitude);
            Assert.AreEqual(-122.12934, location.Point.Longitude);
        }
    }
}
