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

    public GetResults()
    {
      char[] inputArray = _input.ToLower().ToCharArray();
      string results = string.Join("", inputArray);
    }
  }
}
