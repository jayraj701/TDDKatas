using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace TDD.katas
{
   public class Fibonacci
    {

        public static int FibonacciGenerator(int number)
        {
            int FibonacciNumber = 0;
            int FibonacciHelper = 1;

            for (int i = 0; i < number; i++)
            {
                var tempvalue = FibonacciNumber;
                FibonacciNumber = FibonacciHelper ;
                FibonacciHelper = tempvalue + FibonacciHelper;

            }

            return FibonacciNumber;

        }

       
    }
}
