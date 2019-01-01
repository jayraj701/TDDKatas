using System;
using  Shouldly;
using Xunit;

namespace TDD.katas
{
   public class FibonacciTests
    {
        [Fact]
        public void testNthFibonacci()
        {
            var resultedfibonaccinumbers = Fibonacci.bonacciGenerator(0);
            resultedfibonaccinumbers.ShouldBe(0);


        }
    }
}
