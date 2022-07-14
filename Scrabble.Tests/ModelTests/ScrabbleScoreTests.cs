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
    public void GetScore_GiveScoreForLettersEIOULNRST_1()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      scrabble.Word = "e";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
      scrabble.Word = "i";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
      scrabble.Word = "o";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
      scrabble.Word = "u";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
      scrabble.Word = "l";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
      scrabble.Word = "n";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
      scrabble.Word = "r";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
      scrabble.Word = "s";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
      scrabble.Word = "t";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(1, scrabbleScore);
    }

    [TestMethod]
    public void GetScore_GiveScoreForLettersDG_2()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      scrabble.Word = "d";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(2, scrabbleScore);
      scrabble.Word = "g";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(2, scrabbleScore);
    }

    [TestMethod]
    public void GetScore_GiveScoreForLettersBCMP_3()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      scrabble.Word = "b";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(3, scrabbleScore);
      scrabble.Word = "c";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(3, scrabbleScore);
      scrabble.Word = "m";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(3, scrabbleScore);
      scrabble.Word = "p";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(3, scrabbleScore);
    }

    [TestMethod]
    public void GetScore_GiveScoreForLettersFHVWY_4()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      scrabble.Word = "f";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(4, scrabbleScore);
      scrabble.Word = "h";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(4, scrabbleScore);
      scrabble.Word = "v";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(4, scrabbleScore);
      scrabble.Word = "w";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(4, scrabbleScore);
      scrabble.Word = "y";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(4, scrabbleScore);
    }

    [TestMethod]
    public void GetScore_GiveScoreForLettersK_5()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      scrabble.Word = "k";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(5, scrabbleScore);
    }

    [TestMethod]
    public void GetScore_GiveScoreForLettersJX_8()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      scrabble.Word = "j";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(8, scrabbleScore);
      scrabble.Word = "x";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(8, scrabbleScore);
    }

    [TestMethod]
    public void GetScore_GiveScoreForLettersQZ_10()
    {
      ScrabbleScore scrabble = new ScrabbleScore();
      scrabble.Word = "Q";
      int scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(10, scrabbleScore);
      scrabble.Word = "Z";
      scrabbleScore = scrabble.GetScore();
      Assert.AreEqual(10, scrabbleScore);
    }
  }
}