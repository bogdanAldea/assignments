using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Tests
{
    public class ApartmentTests
    {

        private Apartment _apartment;
        
        public void Setup()
        {
            _apartment = new Apartment();
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

    }
}
