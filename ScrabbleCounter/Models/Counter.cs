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
    public int Score
    {
      get
      {
        int score = 0;
        foreach(char letter in this.Letters)
        {
          switch (letter)
          {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'l':
            case 'n':
            case 'r':
            case 's':
            case 't':
              score +=1;
              break;
            case 'd':
            case 'g':
              score +=2;
              break;
            case 'b':
            case 'c':
            case 'm':
            case 'p':
              score +=3;
              break;
            case 'f': 
            case 'h':
            case 'v':
            case 'w':
            case 'y':
              score +=4;
              break;
            case 'k':
              score +=5;
              break;
            case 'j':
            case 'x':
              score +=8;
              break;
            case 'q':
            case 'z':
              score +=10;
              break;
          }
        }     
      return score;
      }
    }
  }
}

