/*
Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
*/


using System;


public class BinaryToDecimal
{
    public static long BinaryToDecimalNumber(string binaryNumber)
    {
        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            int digit = binaryNumber[i] == '0' ? 0 : 1;
            int position = binaryNumber.Length - 1 - i;
            decimalNumber += (long)(digit * Math.Pow(2, position));
        }
        return decimalNumber;
    }

    static void Main()
    {
        Console.Write("Please, enter binary number: ");
        string binary = Console.ReadLine();

        long result = BinaryToDecimalNumber(binary);
        Console.WriteLine("Decimal representation is: " + result);



    }

}


