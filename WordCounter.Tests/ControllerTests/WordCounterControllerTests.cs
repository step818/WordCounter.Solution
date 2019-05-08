using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.TestTools
{
    [TestClass]
    public class WordsControllerTest
    {

      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        WordsController controller = new WordsController();
        ActionResult indexView = controller.Index();
        Assert.IsInstanceOfType(indexView, typeof(ViewResult));
      }

      [TestMethod]
      public void Index_HasCorrectModelType_WordList()
      {
        ViewResult indexView = new WordsController().Index() as ViewResult;
        var result = indexView.ViewData.Model;
        Assert.IsInstanceOfType(result, typeof(List<Word>));
      }

      [TestMethod]
      public void Create_ReturnsCorrectActionType_RedirectToActionResult()
      {
        WordsController controller = new WordsController();
        IActionResult view = controller.Create("Walk the dog");
        Assert.IsInstanceOfType(view, typeof(RedirectToActionResult));
      }

      [TestMethod]
      public void Create_RedirectsToCorrectAction_Index()
      {
        WordsController controller = new WordsController();
        RedirectToActionResult actionResult = controller.Create("walk the dog") as RedirectToActionResult;
        string result = actionResult.ActionName;
        Assert.AreEqual(result, "Index");
      }

    }
}
