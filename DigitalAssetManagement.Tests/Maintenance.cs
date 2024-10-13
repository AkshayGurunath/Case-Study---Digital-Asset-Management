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
    public class PerformMaintenanceTests
    {
        private AssetManagementServiceImpl _assetService;
        private string _connectionString = "Data Source=LAPTOP-2H2P4CPV;Initial Catalog=Asset_Management;Integrated Security=True;";

        [SetUp]
        public void Setup()
        {
            _assetService = new AssetManagementServiceImpl(_connectionString);
        }

        [Test]
        public void PerformMaintenance_Should_AddMaintenanceRecord_When_ValidInput()
        {
            int assetId = 10; // Existing asset
            string maintenanceDate = "2024-10-10";
            string description = "Routine Maintenance";
            double cost = 250.00;

            var result = _assetService.PerformMaintenance(assetId, maintenanceDate, description, cost);

            Assert.IsTrue(result, "Maintenance record should be added successfully.");
        }
    }
}