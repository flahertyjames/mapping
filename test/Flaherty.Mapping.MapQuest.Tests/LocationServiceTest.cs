// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocationServiceTest.cs" company="James Flaherty">
//   2014
// </copyright>
// <summary>
//   The location service test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Flaherty.Mapping.MapQuest
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
            this.service = new LocationService(License.Open, ConfigurationManager.AppSettings["apikey"]);
        }

        /// <summary>
        /// Tests retrieval of a location by an address.
        /// </summary>
        [Test]
        // ReSharper disable once InconsistentNaming
        public void LocationService_LocateFromAddress_ReturnsData()
        {
            var location = this.service.Locate("US", "DC", "20500", "Washington", "1600 Pennsylvania Ave NW");
            Assert.IsNotNull(location);
            Assert.AreEqual("US", location.Address.Country);
            Assert.AreEqual("District of Columbia", location.Address.AdministrativeArea2);
            Assert.AreEqual("20500", location.Address.PostalCode);
            Assert.AreEqual("Washington", location.Address.Locality);
        }

        /// <summary>
        /// Tests retrieval of a location from a query.
        /// </summary>
        [Test]
        // ReSharper disable once InconsistentNaming
        public void LocationService_LocateFromQuery_ReturnsData()
        {
            var location = this.service.Locate("1600 Pennsylvania Ave NW, Washington, DC 20500");
            Assert.IsNotNull(location);
            Assert.AreEqual("US", location.Address.Country);
            Assert.AreEqual("District of Columbia", location.Address.AdministrativeArea2);
            Assert.AreEqual("20500", location.Address.PostalCode);
            Assert.AreEqual("Washington", location.Address.Locality);
        }

        /// <summary>
        /// Tests retrieval of a location by a point.
        /// </summary>
        [Test]
        // ReSharper disable once InconsistentNaming
        public void LocationService_LocateFromPoint_ReturnsData()
        {
            var location = this.service.Locate(38.8977, -77.036553);
            Assert.IsNotNull(location);
            Assert.AreEqual(38.8977, location.Point.Latitude);
            Assert.AreEqual(-77.036553, location.Point.Longitude);
        }
    }
}
