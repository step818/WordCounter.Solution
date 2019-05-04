using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCounterTest
    {

      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
          WordCounterController controller = new WordCounterController();
          ActionResult viewIndex = controller.Index();
          Assert.IsInstanceOfType(viewIndex, typeof(ViewResult));
      }

      [TestMethod]
      public void New_ReturnsCorrectView_True()
      {
          WordCounterController controller = new WordCounterController();
          ActionResult viewIndex = controller.New();
          Assert.IsInstanceOfType(viewIndex, typeof(ViewResult));
      }

    }
}
