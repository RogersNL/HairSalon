using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using HairSalon.Models;

namespace HairSalon.Tests
{
  [TestClass]
  public class ClientTests : IDisposable
  {
    public ClientTests()
    {
        DBConfiguration.ConnectionString = "server=localhost;user id=root;password=root;port=8889;database=nick_rogers_test;";
    }
    public void Dispose()
    {
      Client.DeleteAll();
    }
    [TestMethod]
    public void Save_Test()
    {
      //Arrange
      Client testClient = new Client("Tone", 3);
      testClient.Save();
      //Act
      List<Client> testList = new List<Client>{testClient};
      List<Client> result = Client.GetAll();
      //Assert
      CollectionAssert.AreEqual(testList, result);
    }
    // [TestMethod]
    // public void Find_Test()
    // {
    //   //Arrange
    //   Client testClient = new Client("Jack");
    //   testClient.Save();
    //   //Act
    //   Client result = Client.Find(testClient.GetClientId());
    //   //Assert
    //   Assert.AreEqual(testClient, result);
    // }
  }
}
