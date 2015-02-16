/*
Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits 
(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
*/ 


using System;
using System.Numerics;

class NumberAsArray
{
    static int[] SumOfDigitsOfNumber(int[] firstArray, int[] secondArray)
    {
        if (firstArray.Length > secondArray.Length)
        {
            return SumOfDigitsOfNumber(secondArray, firstArray);
        }

        int[] result = new int[secondArray.Length + 1];
        int i = 0;
        int restOfDigit = 0;


        for (; i < firstArray.Length; i++)
        {
            result[i] = (byte)(firstArray[i] + secondArray[i] + restOfDigit);
            restOfDigit = result[i] / 10;
            result[i] %= 10;
        }


        for (; i < secondArray.Length && restOfDigit != 0; i++)
        {
            result[i] += (byte)(secondArray[i] + restOfDigit);
            restOfDigit = result[i] / 10;
            result[i] %= 10;
        }


        for (; i < secondArray.Length; i++)
        {
            result[i] = secondArray[i];
        }


        if (restOfDigit != 0)
        {
            result[i] = 1;
        }
        else
        {
            Array.Resize(ref result, result.Length - 1); // Remove last digit from the array
        }
        return result;
    }

    static void PrintNumber(int[] result)
    {
        for (int i = result.Length - 1; i >= 0; i--)
        {
            if (result[i] == 0 && i == result.Length - 1)
            {
                continue;
            }
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.Write("Enter first integer number: ");
        string input = Console.ReadLine();
        int[] firstNumberArray = new int[input.Length];

        for (int i = 0; i < firstNumberArray.Length; i++)
        {
            firstNumberArray[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }

        Console.Write("Enter second integer number: ");
        input = Console.ReadLine();
        int[] secondNumberArray = new int[input.Length];

        for (int i = 0; i < secondNumberArray.Length; i++)
        {
            secondNumberArray[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }

        Console.Write("Adds of numbers is: ");
        PrintNumber(SumOfDigitsOfNumber(firstNumberArray, secondNumberArray));
    }
}