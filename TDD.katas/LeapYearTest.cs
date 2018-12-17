using Shouldly;
using Xunit;

namespace TDD.katas
{
    public class LeapYearTest
    {
        [Theory]
        [InlineData(1996)]
        [InlineData(2008)]
        [InlineData(2004)]
        public void LeapYear(int year)
        {
            var isLeapYear = LeapYearIdentifier.IsLeapYear(year);
            isLeapYear.ShouldBeTrue();
        }

        [Theory]
        [InlineData(2001)]
        [InlineData(2002)]
        [InlineData(2003)]

        public void CommonYear(int year)
        {
            var isLeapYear = LeapYearIdentifier.IsLeapYear(year);
            isLeapYear.ShouldBeFalse();
        }


        [Theory]
        [InlineData(1900)]
        [InlineData(100)]
        [InlineData(200)]
        public void ATypicalCommonYear(int year)
        {
            var isLeapYear = LeapYearIdentifier.IsLeapYear(year);
            isLeapYear.ShouldBeFalse();
        }


        [Theory]
        [InlineData(2000)]
        [InlineData(400)]
        [InlineData(800)]
        public void ATypicalLeapYear(int year)
        {
            var isLeapYear = LeapYearIdentifier.IsLeapYear(year);
            isLeapYear.ShouldBeTrue();
        }

    }
}
