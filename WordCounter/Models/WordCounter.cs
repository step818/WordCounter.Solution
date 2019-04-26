using System;

namespace WordCounter
{

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
  		foreach(string word in splitSentence)
  		{
  			if(userWord == word)
  			{
  				count++ ;
  			}
  		}
  		Console.WriteLine("Your have used " + userWord + " " + count + " times.");
  	}

    public class ValidateString(string userInput)
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
  }
}
