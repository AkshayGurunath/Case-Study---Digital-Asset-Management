using DigitalAssetManagement.DAO;
using DigitalAssetManagement.Exception;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAssetManagement.Tests
{
    [TestFixture]
    public class ExceptionTest
    {
        private AssetManagementServiceImpl _assetService;
        private string _connectionString = "Data Source=LAPTOP-2H2P4CPV;Initial Catalog=Asset_Management;Integrated Security=True;";

        [SetUp]
        public void Setup()
        {
            _assetService = new AssetManagementServiceImpl(_connectionString);
        }

        [Test]
        public void ReserveAsset_ShouldThrowAssetNotFoundException_When_AssetIdDoesNotExist()
        {
            // Arrange
            int nonExistentAssetId = 9999; // Use an ID that does not exist in your assets table
            int validEmployeeId = 1; 
            string reservationDate = DateTime.Now.ToString("yyyy-MM-dd");
            string startDate = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd");
            string endDate = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd");

          
            var ex = Assert.Throws<AssetNotFoundException>(() =>
                _assetService.ReserveAsset(nonExistentAssetId, validEmployeeId, reservationDate, startDate, endDate));

            Assert.That(ex.Message, Is.EqualTo($"Asset with ID {nonExistentAssetId} not found."));
        }
    


       
        
    }
}

