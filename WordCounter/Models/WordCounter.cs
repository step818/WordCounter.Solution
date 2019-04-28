using System;

namespace WordCounter
{

  public class WordCounter
  {
    private static int _count;
    private static string _userWord;
    private static string _userSentence;

    public WordCounter(string word, string sentence, int count)
    {
      _userWord = word;
      _userSentence = sentence;
      _count = count;
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

    public bool ValidateString(string userWord)
    {
      return (_userWord is string);
    }

    public bool SplitSentence(string _userSentence)
    {
      string[] splitSentence = _userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
      return (splitSentence is string[]);
    }

    public int CountWord(string _userSentence)
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
