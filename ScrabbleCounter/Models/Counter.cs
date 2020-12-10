using System;
using System.Text.RegularExpressions;

namespace ScrabbleCounter
{
  public class Word
  {
    public string Value { get; private set;}
    public char[] Letters
    {
      get
      {
        if (!Value.Contains(" "))
          return Regex.Replace(Value.ToLower(), "[^a-z+]", "").ToCharArray();
        else 
          throw new Exception("Enter only one word");

      }
    }
    public Word(string Word)
    {
      this.Value = Word;
    }
  }
}