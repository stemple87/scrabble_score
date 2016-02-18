
using System.Collections.Generic;
using Xunit;
namespace ScrabbleScoreNS.Objects
{
  public class ScrabbleScoreTest
  {
    [Fact]
    public void Test1_ToChangeToLowerCase_ReturnLowerCase()
    {
      //Arrange
      string input1 = "HELLO";
      ScrabbleScore testWord = new ScrabbleScore(input1);

      //Act
      string result = testWord.GetResults();

      //Assert
      Assert.Equal("hello", result);
    }
  }
}
