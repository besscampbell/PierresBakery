using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreateInstanceOfPastry_Pastry()
        {
            Pastry pastryOrder = new Pastry(3);
            Assert.AreEqual(typeof(Pastry),pastryOrder.GetType());

        }

        [TestMethod]
        public void TotalPastry_CalculatesPastryTotal_PastryTotal()
        {
            //Arrange
            int pastries = 6;
            Pastry pastryOrder = new Pastry(pastries);
            //Act
            pastryOrder.TotalPastries();
            int result = 10;
            //Assert
            Assert.AreEqual(result, pastryOrder.PastryTotal);
        }

        [TestMethod]
        public void AddPastry_AddsOneToPastryCount_Pastries()
        {
            //Arrange
            Pastry pastryOrder = new Pastry(8);
            //Act
            pastryOrder.AddPastry();
            int result = 9;
            //Assert
            Assert.AreEqual(result, pastryOrder.Pastries);
        }

        [TestMethod]
        public void PastryTotal_CalculatesSinglePastry_PastryTotal()
        {
            //Arrange
            int pastries = 1;
            Pastry pastryOrder = new Pastry(pastries);
            //Act
            pastryOrder.TotalPastries();
            int result = 2;
            //Assert
            Assert.AreEqual(result, pastryOrder.PastryTotal);
        }
    }
}