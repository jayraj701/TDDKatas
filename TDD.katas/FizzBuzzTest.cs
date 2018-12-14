using System;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Schema;
using Shouldly;
using Xunit;

namespace TDD.Katas
{
    public class FizzBuzzTest
    {
        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void MultipleOfFive(int number)
        {
            var testResult = FizzBuzz.FizzBuzzString(number);
            testResult.ShouldBe("Buzz");
        }

        [Theory]
        [InlineData(3)]
        [InlineData(9)]
        public void MultipleOfThree(int number)
        {
            var testResult = FizzBuzz.FizzBuzzString(number);
            testResult.ShouldBe("Fizz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void MultipleOfThreeAndFive(int number)
        {
            var testResult = FizzBuzz.FizzBuzzString(number);
            testResult.ShouldBe("FizzBuzz");
        }

        [Theory]
        [InlineData(11)]
        [InlineData(1)]
        [InlineData(2)]
        public void RandomNumber(int number)
        {
            var testResult = FizzBuzz.FizzBuzzString(number);
            testResult.ShouldBe(number.ToString());
        }

    }
}
