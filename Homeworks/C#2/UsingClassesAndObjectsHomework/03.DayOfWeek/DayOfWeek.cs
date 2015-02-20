/*
Problem 3. Day of week

Write a program that prints to the console which day of the week is today.
Use System.DateTime.
*/ 


using System;

namespace DayOfWeekProblem
{
    class DayOfWeek
    {
        static void Main()
        {
            DateTime today = DateTime.Now;
            Console.WriteLine("Today is: " + today.DayOfWeek);
        }
    }
}
