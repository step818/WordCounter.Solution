using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void ValidateString_ChecksUserInput_True()
    {
      //Arrange
      string testWord = "hi";
      string testSentence = "hi yes";
      int testCount = 1;
      //Act
      WordCounter newWordCounter = new WordCounter(testWord, testSentence, testCount);
      //Assert
      Assert.AreEqual(true, newWordCounter.ValidateString("hello"));
    }

    [TestMethod]
    public void SplitSentence_CheckIfArray_True()
    {
      //Arrange
      string _userSentence = "hello there, how are you?";
      string[] splitSentence = _userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
      //Act
      WordCounter newWordCounter = new WordCounter("hello", "there", 5);
      //Assert
      Assert.AreEqual(true, newWordCounter.SplitSentence("hello there"));
    }

    [TestMethod]
    public void CountWord_HowManyRepeats_Int()
    {
      //Arrange
      string testword = "hello";
      string _userSentence = "hello, how are you?";
      string[] splitSentence = _userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
      //Act
      WordCounter newWordCounter = new WordCounter(testword, _userSentence, 1);
      //Assert
      Assert.AreEqual(1, newWordCounter.CountWord("hello"));
    }

  }
}
