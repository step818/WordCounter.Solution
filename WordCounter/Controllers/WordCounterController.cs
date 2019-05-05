using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/counter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/counter")]
    public ActionResult Create(string word, string sentence)
    {
      CountWords newCount = new CountWords(word, sentence);
      int thisMany = newCount.CountWord(word, sentence);
      return RedirectToAction("Index");
    }

  }
}
