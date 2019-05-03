using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void ValidateWord_ChecksUserWord_True()
    {
      //Arrange
      string testWord = "hi";
      string testSentence = "hi yes";
      int testCount = 1;
      //Act
      WordCounter newWordCounter = new WordCounter(testWord, testSentence, testCount);
      //Assert
      Assert.AreEqual(true, newWordCounter.ValidateWord(testWord));
    }

    [TestMethod]
    public void ValidateSentence_CheckUserSentence_True()
    {
      //Arrange
      string testWord = "yo";
      string testSentence = "yo man";
      int testCount = 1;
      //Act
      WordCounter newWordCounter = new WordCounter(testWord, testSentence, testCount);
      //Assert
      Assert.AreEqual(true, newWordCounter.ValidateSentence(testSentence));
    }

    [TestMethod]
    public void SplitSentence_CheckIfArray_True()
    {
      //Arrange
      string userSentence = "hello there, how are you?";
      string[] splitSentence = userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
      //Act
      WordCounter newWordCounter = new WordCounter("h", userSentence, 5);
      //Assert
      Assert.AreEqual(true, newWordCounter.SplitSentence(userSentence));
    }

    [TestMethod]
    public void CountWord_HowManyRepeats_Int()
    {
      //Arrange
      string testword = "hello";
      string _userSentence = "hello, how are you?hello";
      string[] splitSentence = _userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
      //Act
      WordCounter newWordCounter = new WordCounter(testword, _userSentence, 1);
      //Assert
      Assert.AreEqual(2, newWordCounter.CountWord(_userSentence));
    }

  }
}
