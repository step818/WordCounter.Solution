using System;

namespace WordCounter.Models
{

  public class CountWords
  {
    private static int _count;
    private static string _userWord;
    private static string _userSentence;

    public CountWords(string word, string sentence, int count)
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

    public bool ValidateWord(string userWord)
    {
      return (_userWord is string);
    }

    public bool ValidateSentence(string userSentence)
    {
      return (_userSentence is string);
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
