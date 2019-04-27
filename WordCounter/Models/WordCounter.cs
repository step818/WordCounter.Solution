using System;

namespace WordCounter
{

  public class WordCounterClass
  {
    private static int _count;
    private static string _userWord;
    private static string _userSentence;

    public WordCounterClass(int count, string word, string sentence)
    {
      _count = count;
      _word = word;
      _sentence = sentence;
    }


    public static bool ValidateString(string userInput)
    {
      if (userInput is string)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool SplitSentence(string userSentence)
    {
      string[] splitSentence = userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
      if (splitSentence is string[])
      {
        return true;
      }
      else
      {
        return false;
      }
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
  		string[] splitSentence = userSentence.ToLower().Split(' ', ',', '.', '!', ':', ';', '/', '?', '+');
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
