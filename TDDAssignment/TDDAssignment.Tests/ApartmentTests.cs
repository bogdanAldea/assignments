using Core;
using NUnit.Framework;
using System;

namespace TDDAssignment.Tests
{

    [TestFixture]
    public class ApartmentTests
    {

        private Apartment _apartment;
        private Apartment _apartmentWithUtilities;

        [SetUp]
        public void Setup()
        {
            _apartment = new Apartment();
            _apartmentWithUtilities = new Apartment
            {
                Utilities = { 
                    new Utility { Name = "Util A", IndexMeter = 2},
                    new Utility { Name = "Util B", IndexMeter = 5},
                    new Utility { Name = "Util C", IndexMeter = 3},
                },
            };
        }

        
        [TestCase(4, 10, 40)]
        [TestCase(9, 11, 99)]
        [TestCase(3, 16, 48)]
        public void CalculatePaymentShouldAssignPayment(int price, int utilityIndex, int expectedPayment)
        {
            // Arrange
            _apartment.UtilityIndex = utilityIndex;

            // Act
            _apartment.CalculatePaymen(price);

            // Assert
            Assert.AreEqual(expectedPayment, _apartment.UtilityPayment);
        }

        [TestCase(0, 11)]
        public void CalculatePaymentShouldThrowException(int price, int utilityIndex)
        {

            // Arrange
            _apartment.UtilityIndex = utilityIndex;

            // Act
            //_apartment.CalculatePaymen(price);

            // Assert
            Assert.Throws<ArgumentException>( () => _apartment.CalculatePaymen(price));

        }

        [TestCase(1, 10)]
        [TestCase(2, 20)]
        [TestCase(3, 30)]
        public void CalculateTotalPaymentShouldReturnIntValue(int price, int expectedOutput)
        {
            // Arrange

            //Act
            int output = _apartmentWithUtilities.CalculateTotalPayment(price);

            //Assert
            Assert.AreEqual (expectedOutput, output);
        }

    }
}