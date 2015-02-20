/*
Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
*/ 


using System;

class HexadecimalToDecimal
{

    static long HexadecimalToDecimalNumber(string hexademicalNumber)
    {
        long result = 0;
       
        for (int i = 0; i < hexademicalNumber.Length; i++)
        {
            int digit = 0;
            if (hexademicalNumber[i] >= 0 && hexademicalNumber[i] <= 9)
            {
                digit = hexademicalNumber[i] - '0';
            }
            else if (hexademicalNumber[i] >= 'A' && hexademicalNumber[i] <= 'F') 
            {
                digit = hexademicalNumber[i] - 'A' + 10;
            }
            result += digit * (long)Math.Pow(16, hexademicalNumber.Length - i - 1);
        }
       
        return result;
    }   

    static void Main()
    {
        Console.Write("Please, enter hexademical number: ");
        string hexademical = Console.ReadLine();

        long result = HexadecimalToDecimalNumber(hexademical);
        Console.WriteLine("Decimal representation is: " + result);
    }
}
