using System;
using System.Collections.Generic;

namespace ScrabbleCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Type a word in to see it's Scrabble Score");
      string userInput = Console.ReadLine();
      Word userWord = new Word(userInput);
      Console.WriteLine(userWord.Score);
    }
  }
}