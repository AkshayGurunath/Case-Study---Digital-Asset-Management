using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAssetManagement.DAO;
using DigitalAssetManagement.Entity;
using NUnit.Framework;


namespace DigitalAssetManagement.Tests
{
    [TestFixture]
    public class AssetManagementServiceTests
    {
        public AssetManagementServiceImpl _assetService;
        private string _connectionString = "Data Source=LAPTOP-2H2P4CPV;Initial Catalog=Asset_Management;Integrated Security=True;"; // Replace with your actual connection string

        [SetUp]
        public void Setup()
        {
            _assetService = new AssetManagementServiceImpl(_connectionString);

        }


        [Test]
        public void AddAsset_Should_AddAssetSuccessfully_When_ValidInput()
        {
            // Arrange
            var asset = new Asset
            {
                AssetId = 17,
                Name = "Test Asset",
                Type = "Hardware",
                SerialNumber = "ABC143",
                PurchaseDate = "2024-12-12",
                Location = "Storage",
                Status = "in use",
                OwnerId = 2
            };

            // Act
            var result = _assetService.AddAsset(asset);

            // Assert
            Assert.IsTrue(result, "Asset should be added successfully.");
        }

    }
}