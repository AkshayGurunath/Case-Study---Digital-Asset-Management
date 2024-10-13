using DigitalAssetManagement.DAO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAssetManagement.Tests
{
    [TestFixture]
    public class ReserveAssetTests
    {
        private AssetManagementServiceImpl _assetService;
        private string _connectionString = "Data Source=LAPTOP-2H2P4CPV;Initial Catalog=Asset_Management;Integrated Security=True;";

        [SetUp]
        public void Setup()
        {
            _assetService = new AssetManagementServiceImpl(_connectionString);
        }

        [Test]
        public void ReserveAsset_Should_ReserveAssetSuccessfully_When_ValidInput()
        {
            // Arrange
            int assetId = 10; // Ensure this asset exists in your database
            int userId = 2;   // Replace with a valid user ID
            string reservationDate = "2024-10-12";
            string returnDate = "2024-10-15";
            string endDate = "2024-10-20";

            // Act
            var result = _assetService.ReserveAsset(assetId, userId, reservationDate, returnDate, endDate);

            // Assert
            Assert.IsTrue(result, "Asset should be reserved successfully.");
        }
    }
}
