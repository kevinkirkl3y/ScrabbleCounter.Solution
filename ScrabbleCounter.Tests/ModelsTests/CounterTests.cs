using Microsoft.VisualStudio.TestTools.UnitTesting;
// using System;
// using System.Collections.Generic;
// using ScrabbleCounter;
using System.Linq;
//using static System.Char;



namespace ScrabbleCounter.Tests
{
  [TestClass]
  public class CounterTests
  {
    [TestMethod]
    public void Letters_ChecksForInstanceOfArray_True()
    {
      //Arrange
      char chA = 'a';
      //Act
      char[] newArr = new char[chA];
      //Assert
      Assert.AreEqual(typeof(char[]), newArr.GetType()); 
    }
    [TestMethod]
    public void Word_CreatesInstanceOfWord_True()
    {
      string test = "test";
      
      Word newWord = new Word(test);
      Assert.AreEqual(newWord.Value, "test");
    }
    [TestMethod]
    public void Letters_PushesValueIntoCharacterArray_True()
    {
      string test = "test";
      Word newWord = new Word(test);

      Assert.AreEqual(newWord.Letters.Any(), true);
    }
    [TestMethod]
    [ExpectedException(typeof(System.Exception), "Enter only one word")]
    public void Letters_ThrowsExceptionForMultipleWords_True()
    {
      string test = "hello world";
      Word newWord = new Word(test);
      newWord.Letters.Any();
    }
    [TestMethod]
    public void Score_ReturnsIntegerValueForScore_True()
    {
    string test = "test";
    Word newWord = new Word(test);
    Assert.AreEqual(typeof(int), newWord.Score.GetType());
    }
    [TestMethod]
    public void Score_CorrectlyCalculatesScoreOfInputtedWord_True()
    {
      string test = "qi";
      Word newWord = new Word(test);
      Assert.AreEqual(11,newWord.Score);
    }

  }
}