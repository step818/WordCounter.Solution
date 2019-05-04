using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class HomeControllerTest
    {

      [TestMethod]
      public void Index_ReturnsCorrectView_True()
      {
        //Arrange
        HomeController controller = new HomeController();
        //Act
        ActionResult index = controller.Index();
        //Assert
        Assert.IsInstanceOfType(index, typeof(ViewResult));
      }

    }
}
