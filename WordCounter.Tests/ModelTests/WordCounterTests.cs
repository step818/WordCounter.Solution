using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System.Collections.Generic;
using System;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest : IDisposable
  {
    public void Dispose()
    {
      Word.ClearAll();
    }

    [TestMethod]
    public void WordConstructor_CreatesInstanceOfWord_Word()
    {
      Word newWord = new Word("Test");
      Assert.AreEqual(typeof(Word), newWord.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnsDescription_String()
    {
      string userWord = "dog.";
      Item newWord = new Word(userWord);
      string result = newWord.GetWord();
      Assert.AreEqual(userWord, result);
    }

    [TestMethod]
    public void GetId_ItemsInstantiateWithIdAndGetterReturns_int()
    {
      string description = "Walk the dog.";
      Item newItem = new Item(description);
      int result = newItem.GetId();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCoreectItem_Item()
    {
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Item newItem1 = new Item(description01);
      Item newItem2 = new Item(description02);
      Item result = Item.Find(2);
      Assert.AreEqual(newItem2, result);
    }
  }
}
