using System.Collections.Generic;
using System;
using System.Text.RegularExpressions;

namespace ScrabbleScoreNS.Objects
{
  public class ScrabbleScore
  {
    private string _input;

    public ScrabbleScore(string myInput)
    {
      _input = myInput;
    }

    public int GetResults()
    {
      int points = 0;
      char[] inputArray = _input.ToLower().ToCharArray();
      for(var i = 0; i < inputArray.Length; i++)
      {
        if(inputArray[i] == 'a' || inputArray[i] == 'e' || inputArray[i] == 'i' || inputArray[i] == 'o' || inputArray[i] == 'u' || inputArray[i] == 'l' || inputArray[i] == 'n' || inputArray[i] == 'r' || inputArray[i] == 's' || inputArray[i] == 't')
        {
          points += 1;
        }
        else if (inputArray[i] == 'd' || inputArray[i] == 'g')
        {
          points += 2;
        }
        else if (inputArray[i] == 'b' || inputArray[i] == 'c' || inputArray[i] == 'm' || inputArray[i] == 'p')
        {
          points += 3;
        }
        else if (inputArray[i] == 'f' || inputArray[i] == 'h' || inputArray[i] == 'v' || inputArray[i] == 'w' || inputArray[i] == 'y')
        {
          points += 4;
        }
        else if (inputArray[i] == 'k')
        {
          points += 5;
        }
        else if (inputArray[i] == 'j' || inputArray[i] == 'x')
        {
          points += 8;
        }
        else if (inputArray[i] == 'q' || inputArray[i] == 'z')
        {
          points += 10;
        }
        else
        {
          points += 0;
        }
      }

      return points;
    }
  }
}
