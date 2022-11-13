namespace TestProject1PercentageNET.tests.UnitTests;

using PercentageNET;

public class PercentageHelperTests
{
    
    [Theory]
    [InlineData(50,50,75)]
    public void ShouldIncreasePercent(decimal originalNumber, decimal percentageToIncreaseBy, decimal expectedResult)
    {
        var result = PercentageHelper.Add(originalNumber, percentageToIncreaseBy);
        
        Assert.Equal(expectedResult,result);
    }
}