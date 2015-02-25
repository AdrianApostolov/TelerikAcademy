﻿/*
Problem 1. Square root

Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block.
*/ 


using System;

namespace SquareRootProblem
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Please, inter an integer number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
               
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
               
                double result = Math.Sqrt(number);
                Console.WriteLine("The square root of given number is: " + result);
            }
            catch (FormatException ex)
            {

                Console.WriteLine("Invalid number", ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Invalid number", ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Invalid number", ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
