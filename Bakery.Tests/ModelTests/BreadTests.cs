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
          int loaves = 5;
          Bread breadOrder = new Bread(loaves);
          //Act
          breadOrder.TotalBread();
          int result = 20;
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

      [TestMethod]
      public void TotalBread_CalculatesSingleLoaf_BreadTotal()
      {
         //Arrange
          int loaves = 1;
          Bread breadOrder = new Bread(loaves);
          //Act
          breadOrder.TotalBread();
          int result = 5;
          //Assert
          Assert.AreEqual(result, breadOrder.BreadTotal); 
      }

      [TestMethod]
      public void TotalBread_CalculatesLargeOrders_BreadTotal()
      {
         //Arrange
          int loaves = 34;
          Bread breadOrder = new Bread(loaves);
          //Act
          breadOrder.TotalBread();
          int result = 115;
          //Assert
          Assert.AreEqual(result, breadOrder.BreadTotal);  
      }

      [TestMethod]
      public void TotalBread_MultiplesOfThree_BreadTotal()
      {
          //Arrange
          int loaves = 9;
          Bread breadOrder = new Bread(loaves);
          //Act
          breadOrder.TotalBread();
          int result = 30;
          //Assert
          Assert.AreEqual(result, breadOrder.BreadTotal); 
      }

      //Multiple of 3 vs Multiple of 2 same price difference is in the loaves. Prompt customer to get one more for free

       [TestMethod]
      public void TotalBread_MultiplesOfTwo_BreadTotal()
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
    }
}