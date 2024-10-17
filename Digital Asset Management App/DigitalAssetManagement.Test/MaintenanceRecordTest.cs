using DigitalAssetManagement.Business.Repository;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAssetManagement.Test
{
    [TestFixture]
    public class MaintenanceRecordsRepositoryTests
    {
        private MaintenanceRecordsRepository _maintenanceRecordsRepository;

        [SetUp]
        public void Setup()
        {
            _maintenanceRecordsRepository = new MaintenanceRecordsRepository();
           
        }

        [Test]
        public void PerformMaintenance_Should_AddMaintenanceRecord_When_ValidInput()
        {
            // Arrange
            int assetId = 1; 
            DateTime maintenanceDate = DateTime.Now; 
            string description = "Routine maintenance";
            double cost = 150.00;

            // Act
            var result = _maintenanceRecordsRepository.PerformMaintenance(assetId, maintenanceDate, description, cost);

            // Assert
            Assert.IsTrue(result, "Maintenance record should be added successfully.");
        }

    }



}
