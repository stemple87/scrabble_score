
using System.Collections.Generic;
using Xunit;
namespace ScrabbleScoreNS.Objects
{
  public class ScrabbleScoreTest
  {
    [Fact]
    public void Test1_ToSeeIfPointsAdded_Return1()
    {
      //Arrange
      string input1 = "A";
      ScrabbleScore testPoints = new ScrabbleScore(input1);

      //Act
      int result = testPoints.GetResults();

      //Assert
      Assert.Equal(1, result);
    }

    [Fact]
    public void Test2_ToSeeIfPointsAdded_ReturnDictionary()
    {
      //Arrange
      string input1 = "A";
      ScrabbleScore testPoints = new ScrabbleScore(input1);

      //Act
      int result = testPoints.GetResults();

      //Assert
      Assert.Equal(1, result);
    }
    [Fact]
    public void Test3_ToSeeIfPointsAddedHell0_Return7()
    {
      //Arrange
      string input1 = "hell0";
      ScrabbleScore testPoints = new ScrabbleScore(input1);

      //Act
      int result = testPoints.GetResults();

      //Assert
      Assert.Equal(7, result);
    }
  }
}
