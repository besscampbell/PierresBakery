using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery.Tests
{
    [TestClass]
    public class BreadTests
    {
      [TestMethod]
      public void BreadConstructor_CreateInstancesOfWord_Bread()
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
    }
}