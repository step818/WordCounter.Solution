using System;

namespace WordCounter
{

  public class WordCounter
  {
    private static int _count;
    private static string _userWord;
    private static string _userSentence;

    public WordCounter(int count, string word, string sentence)
    {
      _count = count;
      _userWord = word;
      _userSentence = sentence;
    }

    public static int GetCount()
    {
        return _count;
    }

    public static string GetWord()
    {
        return _userWord;
    }

    public static string GetSentence()
    {
        return _userSentence;
    }

    public bool ValidateString(string userInput)
    {
      if (_userWord is string)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool SplitSentence()
    {
      string[] splitSentence = _userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
      if (splitSentence is string[])
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public int CountWord()
    {
      string word = GetWord();
      int count = 0;
      string[] splitSentence = userSentence.ToLower().Split(' ', ',', '.', '!', ';', ':', '/', '?', '+');
      foreach(string word in splitSentence)
      {
          if(_userWord == word)
          {
            count++
          }
      }
      _count = count;
      return _count;
    }
  }

  public class Program
  {
  	public static void Main()
  	{
  		int count = 0;
  		Console.WriteLine("Enter a word: ");
  		string userWord = Console.ReadLine();
  		Console.WriteLine("Enter a sentence with that word: ");
  		string userSentence = Console.ReadLine();
      ValidateString(userWord);
      SplitSentence(userSentence);
  		foreach(string word in splitSentence)
  		{
  			if(userWord == word)
  			{
  				count++ ;
  			}
  		}
  		Console.WriteLine("Your have used " + userWord + " " + count + " times.");
  	}



  }
}
