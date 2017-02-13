using Xunit;

namespace LeapYearVerify
{
  public class LeapYearTest
  {
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFour_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false, testLeapYear.IsLeapYear(1997));
    }
    [Fact]
    public void IsLeapYear_ForNumberDivisibleByFour_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(2012));
    }
    [Fact]
    public void IsLeapYear_ForMultiplesOfOneHundred_false()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(false, testLeapYear.IsLeapYear(1900));
    }
    [Fact]
    public void IsLeapYear_ForMultiplesOfFourHundred_true()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.Equal(true, testLeapYear.IsLeapYear(2000));
    }
  }
}
