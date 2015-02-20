/*
Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

     input	       output
"43 68 9 23 318"	461
*/ 


using System;
using System.Collections.Generic;
using System.Linq;


namespace SumIntegersProblem
{
    class SumIntegers
    {
        static void Main()
        {
            Console.Write("Enter integers, separated by a spaces: ");
            int[] input = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int result = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                result += input[i];
            }

            Console.WriteLine("The sum is: " + result);
        }
    }
}
