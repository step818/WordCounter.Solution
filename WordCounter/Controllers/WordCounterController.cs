using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class WordCounterController : Controller
  {
    [HttpGet("/counter")]
    public ActionResult Index()
    {

    }

    [HttpPost("/answer")]
    public ActionResult Create(string word, string sentence)
    {
      
    }

  }
}