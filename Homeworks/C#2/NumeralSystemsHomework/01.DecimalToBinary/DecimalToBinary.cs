/*
Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
*/


using System;

class DecimalToBinary
{

    static string DecimalToBinarty(int decimalNumber)
    {
        int remainder;
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            remainder = decimalNumber % 2;
            decimalNumber /= 2;
            result = remainder.ToString() + result;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Please, enter decimal number: ");
        int decimalNumber = int.Parse(Console.ReadLine());
        string result = DecimalToBinarty(decimalNumber);
        Console.WriteLine("Binary representation: {0}", result);
    }
}
