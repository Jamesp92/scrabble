using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;
using System;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleScoreTests
  {

    [TestMethod]
    // NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    public void ScrabbleScoreConstructor_CreatesInstanceOfScrabbleScore_ScrabbleScore()
    {
      ScrabbleScore scrabbleS = new ScrabbleScore();
      // class == object == data type
      Assert.AreEqual(typeof(ScrabbleScore), scrabbleS.GetType());
    }

    [TestMethod]
    public void GetScore_GiveScoreForLetterA_1()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      // below currently won't work
      scrabble.Word = "a";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
    }

    [TestMethod]
    public void GetScore_GiveScoreForLettersAEIOULNRST_1()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      scrabble.Word = "o";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
    }
  }
}