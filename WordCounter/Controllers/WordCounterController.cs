using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/counter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/answer")]
    public ActionResult Create(string word, string sentence, int count)
    {
      CountWords newCount = new CountWords(word, sentence, count);
      int thisMany = newCount.CountWord();
      return RedirectToAction("Index");
    }

  }
}
