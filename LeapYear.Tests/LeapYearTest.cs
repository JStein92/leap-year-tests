using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeapYear;

namespace LeapYear.Tests
{
    [TestClass]
    public class LeapYearTest
    {
      [TestMethod]
      public void IsLeapYear_ForNumberDivisibleByFour_True()
      {
        LeapYear testLeapYear = new LeapYear();
        Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));
      }
      [TestMethod]
      public void IsLeapYear_ForNumberNotDivisibleByFour_False()
      {
        LeapYear testLeapYear = new LeapYear();
        Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
      }
      [TestMethod]
      public void IsLeapYear_ForMultiplesOfOneHundred_False()
      {
        LeapYear testLeapYear = new LeapYear();
        Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
      }
      [TestMethod]
      public void IsLeapYear_ForMultiplesOfFourHundred_True()
      {
        LeapYear testLeapYear = new LeapYear();
        Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
      }
    }
}
