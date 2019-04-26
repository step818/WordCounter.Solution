using System;
using WordCounter;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsAString_ChecksUserInput_True()
    {
      string userWord = "yes";
      WordCounter newWordCounter = new WordCounter();
      Assert.AreEqual(true, newWordCounter.IsAString(userword))
    }

    [TestMethod]
    public void RepeatCounter_CountsWordInAString_Int()
    {

      userWord = "bike"
      userSentence = "I have 3 bikes, my bike in Seattle is not really my bike, but my girlfriend's bike."

      Assert.AreEqual(3, RepeatCounter(userWord, userSentence))
    }

  }
}
