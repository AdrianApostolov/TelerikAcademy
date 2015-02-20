/*
Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
*/ 


using System;

namespace LeapYearProblem
{
    class LeapYear
    {
        static void Main()
        {
            Console.Write("Please, enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (DateTime.IsLeapYear(year) == true)
            {
                Console.WriteLine("The year is leap.");
            }
            else
            {
                Console.WriteLine("The year is not leap.");
            }
           
        }
    }
}
