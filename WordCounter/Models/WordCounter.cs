using System;

namespace WordCounter
{

  public class WordCounter
  {
    // private static int _count;
    private static string _userWord;
    private static string _userSentence;

    public WordCounter(string word, string sentence)
    {
      // _count = count;
      _userWord = word;
      _userSentence = sentence;
    }
    //
    // public static int GetCount()
    // {
    //     return _count;
    // }

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
      string[] splitSentence = _userSentence.ToLower().Split(' ', ',', '.', '!', ';', ':', '/', '?', '+');
      foreach(string element in splitSentence)
      {
          if(_userWord == element)
          {
            count++;
          }
      } return count;

    }
  }

  }
