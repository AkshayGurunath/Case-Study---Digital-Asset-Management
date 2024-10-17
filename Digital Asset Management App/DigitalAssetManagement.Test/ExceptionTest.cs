using DigitalAssetManagement.Business.Repository;
using DigitalAssetManagement.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalAssetManagement.Test
{
    namespace DigitalAssetManagement.Test
    {
        [TestFixture]
        public class ReservationRepositoryTests
        {
            private ReservationRepository _reservationRepository;
            private string _connectionString;

            [SetUp]
            public void Setup()
            {
                // Retrieve connection string from app config
                _connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
                _reservationRepository = new ReservationRepository();
            }

            [Test]
            public void ReserveAsset_Should_ThrowEmployeeNotFoundException_When_InvalidUserId()
            {
                // Arrange
                int assetId = 10; // Assume this asset ID exists
                int invalidUserId = 999; // Non-existent user ID
                DateTime reservationDate = DateTime.Now;
                DateTime returnDate = reservationDate.AddDays(3);
                DateTime endDate = reservationDate.AddDays(7);

                // Act & Assert
                var ex = Assert.Throws<EmployeeNotFoundException>(() =>
                    _reservationRepository.ReserveAsset(assetId, invalidUserId, reservationDate, returnDate, endDate));

                Assert.That(ex.Message, Is.EqualTo("Employee with ID 999 not found.")); // Adjust message as necessary
            }

            [Test]
            public void ReserveAsset_Should_ThrowAssetNotFoundException_When_InvalidAssetId()
            {
                // Arrange
                int invalidAssetId = 999; // Non-existent asset ID
                int userId = 2; // Assume this user ID exists
                DateTime reservationDate = DateTime.Now;
                DateTime returnDate = reservationDate.AddDays(3);
                DateTime endDate = reservationDate.AddDays(7);

                // Act & Assert
                var ex = Assert.Throws<AssetNotFoundException>(() =>
                    _reservationRepository.ReserveAsset(invalidAssetId, userId, reservationDate, returnDate, endDate));

                Assert.That(ex.Message, Is.EqualTo("Asset with ID 999 not found.")); // Adjust message as necessary
            }
        }
    }
}
    
