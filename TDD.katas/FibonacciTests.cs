﻿using System;
using  Shouldly;
using Xunit;

namespace TDD.katas
{
   public class FibonacciTests
    {
        [Fact]
        public void testNthFibonacci0thposition()
        {
            var resultedfibonaccinumbers = Fibonacci.bonacciGenerator(0);
            resultedfibonaccinumbers.ShouldBe(0);


        }
        [Fact]
        public void testNthFibonacci1stposition()
        {
            var resultedfibonaccinumbers = Fibonacci.bonacciGenerator(1);
            resultedfibonaccinumbers.ShouldBe(1);


        }
    }
}
