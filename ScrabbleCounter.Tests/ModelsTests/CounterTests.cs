using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleCounter;
using System;
using System.Collections.Generic;

namespace ScrabbleCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void StrCheck_ChecksIfInputIsString_True()
    {
      //Arrange
      string userInput = "string";
      //Act
      bool val = StrCheck(userInput);
      //Assert
      Assert.AreEqual(true, val); 
    }
  }
}