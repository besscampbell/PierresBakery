using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
      [TestMethod]
      public void BreadConstructor_CreateInstancesOfBread_Bread()
      {
          Bread breadOrder = new Bread(5);
          Assert.AreEqual(typeof(Bread), breadOrder.GetType());
      }

      [TestMethod]
      public void TotalBread_CalculatesBreadTotal_BreadTotal()
      {
          //Arrange
          int loaves = 8;
          Bread breadOrder = new Bread(loaves);
          //Act
          breadOrder.TotalBread();
          int result = 30;
          //Assert
          Assert.AreEqual(result, breadOrder.BreadTotal);
      }

      [TestMethod]
      public void AddLoaf_AddsOneToLoafCount_Loaves()
      {
          //Arrange
          Bread breadOrder = new Bread(5);
          //Act
          breadOrder.AddLoaf();
          int result = 6;
          //Assert
          Assert.AreEqual(result, breadOrder.Loaves);
      }
    }
}