using System;
using System.Collections.Generic;
using  Shouldly;
using Xunit;

namespace TDD.katas
{
   public class FibonacciTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void testNthFibonacciNumber(int number)
        {
           
            Dictionary<int,int> testData = new Dictionary<int, int>();

            testData.Add(0,0);
            testData.Add(1,1);
            testData.Add(2,1);


            var resultedfibonaccinumbers = Fibonacci.FibonacciGenerator(number);

            resultedfibonaccinumbers.ShouldBe(testData[number]);


        }
      
    }
}
