using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string toString = Console.ReadLine();
        long result = 0;

        for (int i = toString.Length - 1; i >= 0; i--)
        {
            result += long.Parse(toString[toString.Length - i - 1].ToString()) * (long)Math.Pow(2, i);
        }

        Console.WriteLine("Result: " + result);
    }
}

