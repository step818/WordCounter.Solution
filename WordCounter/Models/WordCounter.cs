using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class Word
  {
      private string _word;
      private string _sentence;
      private int _id;
      private static List<Word> _instances = new List<Word>{};

      public Word (string word, string sentence)
      {
          _word = word;
          _sentence = sentence;
          _instances.Add(this);
          _id = _instances.Count;
      }

      public string GetWord()
      {
          return _word;
      }
      public string GetSentence()
      {
          return _sentence;
      }

      public bool ValidateWord(string userWord)
      {
        return (_word is string);
      }

      public bool ValidateSentence(string userSentence)
      {
        return (_sentence is string);
      }

      public bool SplitSentence(string _userSentence)
      {
        string[] splitSentence = _userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
        return (splitSentence is string[]);
      }

      public int CountWord()
      {
          // string repeatWord = GetWord();
          // string sentence = GetSentence();
          int count = 0;
          string[] splitSentence = _sentence.ToLower().Split(' ', ',', '.', '!', ';', ':', '/', '?', '+');
          foreach(string element in splitSentence)
          {
              if(_word == element)
              {
                count++;
              }
          } return count;

      }

      public static List<Word> GetAll()
      {
          return _instances;
      }

      public static void ClearAll()
      {
          _instances.Clear();
      }

      public void SetWord(string newWord)
      {
        _word = newWord;
      }
      public int GetId()
      {
        return _id;
      }
      public static Word Find(int searchId)
      {
        return _instances[searchId-1];
      }



  }
}
