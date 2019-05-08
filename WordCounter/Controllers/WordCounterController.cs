using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {

    [HttpGet("/words")]
    public ActionResult Index()
    {
      List<Word> allWords = Word.GetAll();
      return View(allWords);
    }

    [HttpGet("/words/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/words")]
    public ActionResult Create(string word, string sentence)
    {
      Word myWord = new Word(word, sentence);
      int thisMany = myWord.CountWord();
      return RedirectToAction("Index");
    }

    [HttpPost("/words/delete")]
    public ActionResult DeleteAll()
    {
      Word.ClearAll();
      return View();
    }

    [HttpGet("/words/{id}")]
    public ActionResult Show(int id)
    {
      Word word = Word.Find(id);
      return View(word);
    }


  }
}
