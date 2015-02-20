/*
Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
*/ 


using System;

class DecimalToHexademical
{
    static string DecimalToHexademicalNumber (long decimalNumber) 
    {
        string result = string.Empty;
        while (decimalNumber > 0)
        {
            int remainder = (int)decimalNumber % 16;
            if (remainder >= 0 && remainder <= 9)
            {
                result = (char)(remainder + '0') + result;
            }
            else if (remainder >= 10 && remainder <= 15)
            {
                result = (char)(remainder - 10 + 'A') + result;
            }
            decimalNumber /= 16;
        
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Please, enter decimal number: ");
        long decimalNumber = int.Parse(Console.ReadLine());
        string result = DecimalToHexademicalNumber(decimalNumber);
        Console.WriteLine("Hexademical representation is: {0}", result);
    }
}

