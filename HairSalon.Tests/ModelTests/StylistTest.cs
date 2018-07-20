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
      Console.WriteLine(testList.Count);
      Console.WriteLine(result.Count);
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
    [TestMethod]
    public void Edit_Test()
    {
      //Arrange
      string  testName = "A Friend";
      Stylist testStylist = new Stylist(testName);
      testStylist.Save();
      string updateName = "Dovydas";
      //Act
      testStylist.Edit(updateName);
      string result = Stylist.Find(testStylist.GetStylistId()).GetStylistName();
      //Assert
      Assert.AreEqual(updateName, result);
    }
    [TestMethod]
    public void Delete_Test()
    {
      //Arrange
      Stylist testStylist = new Stylist("Brunet");
      testStylist.Save();
      Stylist newTestStylist = new Stylist("Nate");
      newTestStylist.Save();
      List<Stylist> beforeDeleteList = new List<Stylist>{testStylist, newTestStylist}; //Use to make test fail
      List<Stylist> afterDeleteList = new List<Stylist>{newTestStylist}; //Use to make test pass

      //Act
      Stylist.Find(testStylist.GetStylistId()).Delete();
      List<Stylist> result = Stylist.GetAll();
      //Assert
      CollectionAssert.AreEqual(afterDeleteList, result);
    }
    [TestMethod]
    public void GetSpecialties_Test()
    {
      //Arrange
      Stylist newStylist = new Stylist("Luffy");
      newStylist.Save();
      Specialty newSpecialty = new Specialty("Haki");
      newSpecialty.Save();
      Specialty newSpecialty1 = new Specialty("Gum Gum Devil Fruit");
      newSpecialty1.Save();

      //Act
      newStylist.AddSpecialty(newSpecialty);
      newStylist.AddSpecialty(newSpecialty1);

      List<Specialty> expectedResult = new List<Specialty>{newSpecialty, newSpecialty1};
      List<Specialty> result = newStylist.GetSpecialties();

      //Assert
      CollectionAssert.AreEqual(expectedResult, result);
    }
  }
}
