using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DigitalAssetManagement.Business;
using DigitalAssetManagement.Business.Repository;
using DigitalAssetManagement.Business.Services;
using DigitalAssetManagement.Entity;
using DigitalAssetManagement.Exceptions;
using NUnit.Framework;

namespace DigitalAssetManagement.Test
{
    [TestFixture]
    public class AssetServiceTests
    {
        private AssetRepository _assetRepository;
        private Asset _testAsset;

        [SetUp]
        public void Setup()
        {
            _assetRepository = new AssetRepository();
            _testAsset = new Asset
            {
                AssetId = 21,
                Name = "Test Asset",
                Type = "Type A",
                SerialNumber = "SN123456",
                PurchaseDate = "2024-12-12",
                Location = "Test Location",
                Status = "Available",
                OwnerId = 1
            };

            // Add the test asset to the repository before running tests
            _assetRepository.AddAsset(_testAsset);
        }

        [Test]
        public void AddAsset_ShouldReturnTrue_WhenAssetIsAdded()
        {
            // This test checks if adding a new asset returns true.
            Asset newAsset = new Asset
            {
                AssetId = 22, // Ensure unique AssetId
                Name = "New Test Asset",
                Type = "Type B",
                SerialNumber = "SN654321",
                PurchaseDate = "2024-12-15",
                Location = "New Test Location",
                Status = "Available",
                OwnerId = 2
            };

            bool result = _assetRepository.AddAsset(newAsset);
            Assert.IsTrue(result);
        }

        [Test]
        public void UpdateAsset_ShouldReturnTrue_WhenAssetIsUpdated()
        {
            // Update the asset details
            _testAsset.Name = "Updated Asset";
            bool result = _assetRepository.UpdateAsset(_testAsset);
            Assert.IsTrue(result);
        }

        [Test]
        public void DeleteAsset_ShouldReturnTrue_WhenAssetIsDeleted()
        {
            // Deleting the asset we added in Setup
            bool result = _assetRepository.DeleteAsset(_testAsset.AssetId);
            Assert.IsTrue(result);
        }

        [TearDown]
        public void Cleanup()
        {
            // Clean up any added assets after each test to avoid conflicts
            _assetRepository.DeleteAsset(_testAsset.AssetId);
        }
    }
}


