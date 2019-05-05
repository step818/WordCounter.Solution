using System;
using WordCounter;

namespace WordCounter.Models
{

  public class CountWords
  {

    private string _userWord;
    private string _userSentence;

    public CountWords(string word, string sentence)
    {
      _userWord = word;
      _userSentence = sentence;

    }


    public string GetWord()
    {
        return _userWord;
    }

    public string GetSentence()
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

    public int CountWord(string word, string sentence)
    {
      // string word = GetWord();
      // string sentence = GetSentence();
      int count = 0;
      string[] splitSentence = sentence.ToLower().Split(' ', ',', '.', '!', ';', ':', '/', '?', '+');
      foreach(string element in splitSentence)
      {
          if(word == element)
          {
            count++;
          }
      } return count;

    }
  }

  }
