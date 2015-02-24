/*
Problem 11. Format number

Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation.
Format the output aligned right in 15 symbols.
*/ 


using System;
using System.Globalization;
using System.Threading;

namespace FormatNumberProblem
{
    class FormatNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            
            Console.Write("Please, enter one number: ");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15} {1,15} {2,15} {3,15}\n","Decimal","Hex","Percentage","Scientific");

            string formatString = string.Format("{0,15:D} {0,15:X} {0,15:P} {0,15:E}",number);
            Console.WriteLine(formatString);
        }
    }
}
