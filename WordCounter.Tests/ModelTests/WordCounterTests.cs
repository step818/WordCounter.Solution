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
      RepeatCounter newWordCounter = new RepeatCounter();
      Assert.AreEqual(true, newWordCounter.ValidateString("hello"));
    }

    [TestMethod]
    public void SplitSentence_CheckIfArray_True()
    {
      RepeatCounter newWordCounter = new RepeatCounter();
      Asssert.AreEqual(true, newWordCounter.SplitSentence("hello there, how are you?"));
    }

    // [TestMethod]
    // public void RepeatCounter_CountsWordInAString_Int()
    // {
    //
    //   userWord = "bike"
    //   userSentence = "I have 3 bikes, my bike in Seattle is not really my bike, but my girlfriend's bike."
    //
    //   Assert.AreEqual(3, RepeatCounter(userWord, userSentence))
    // }

  }
}
