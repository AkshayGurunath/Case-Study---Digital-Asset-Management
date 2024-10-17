using DigitalAssetManagement.Business.Repository;
using DigitalAssetManagement.Business.Services;
using NUnit.Framework;
using System;
using System.Configuration;

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
            _connectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString; // Replace with your actual connection string name

            // Initialize the repository with the connection string
            _reservationRepository = new ReservationRepository();
        }

        [Test]
        public void ReserveAsset_Should_ReserveAssetSuccessfully_When_ValidInput()
        {
            // Arrange
            int assetId = 10;
            int userId = 2;
            DateTime reservationDate = new DateTime(2024, 10, 12);
            DateTime returnDate = new DateTime(2024, 10, 15);
            DateTime endDate = new DateTime(2024, 10, 20);

            // Act
            var result = _reservationRepository.ReserveAsset(assetId, userId, reservationDate, returnDate, endDate);

            // Assert
            Assert.IsTrue(result, "Asset should be reserved successfully.");
        }
    }
}