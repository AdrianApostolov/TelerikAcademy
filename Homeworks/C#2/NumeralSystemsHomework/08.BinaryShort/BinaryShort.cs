/*
Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
*/ 


using System;


class BinaryShort
{
    static string inBinary(short number)
    {
        string bin = String.Empty;
        for (int i = 0; i < 16; i++)
        {
            bin = (number >> i & 1) + bin;
        }
        return bin;
    }   

    static void Main()
    {
        Console.Write("Enter short nubmer between[{0} , {1}]: ", short.MinValue, short.MaxValue);
        short numberInput = short.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation is: " + inBinary(numberInput));
    }
}

