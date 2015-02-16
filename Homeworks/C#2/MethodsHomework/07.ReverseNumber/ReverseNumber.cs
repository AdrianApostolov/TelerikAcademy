/*
Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
Example:

input	output
256	    652
*/

using System;

class ReverseNumber
{
    static decimal ReverseDigitDecimalNumber(decimal number)
    {
        char[] temp = number.ToString().ToCharArray();

        char[] reversed = new char[temp.Length];

        for (int index = 0; index < temp.Length; index++)
        {
            reversed[temp.Length - index - 1] = temp[index];
        }
        return decimal.Parse(new string(reversed));;
    }
    static void Main()
    {
        Console.Write("Enter decimal value: ");
        decimal decimalNumber = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Reversed: " + ReverseDigitDecimalNumber(decimalNumber));
    }
}

