using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class StylistTests : IDisposable
  {
    public StylistTests()
    {
        DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=nick_rogers_test;";
    }
    public void Dispose()
    {
      Stylist.DeleteAll();
    }
    [TestMethod]
    public void Save_Test()
    {
      //Arrange
      Stylist testStylist = new Stylist("Jain");
      testStylist.Save();
      //Act
      List<Stylist> testList = new List<Stylist>{testStylist};
      List<Stylist> result = Stylist.GetAll();
      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
    [TestMethod]
    public void Find_Test()
    {
      //Arrange
      Stylist testStylist = new Stylist("Jack");
      testStylist.Save();
      //Act
      Stylist result = Stylist.Find(testStylist.GetStylistId());
      //Assert
      Assert.AreEqual(testStylist, result);
    }
  }
}
