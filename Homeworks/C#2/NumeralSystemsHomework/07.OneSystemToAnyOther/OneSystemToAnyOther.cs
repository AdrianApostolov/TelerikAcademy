/*
Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
*/ 

using System;
using System.Text;


public class OneSystemToAnyOther
{
    static void Main()
    {
        Console.Write("Please, enter numeral system you want to convert (2<= s <=16): ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please, enter number: ");
        string number = Console.ReadLine();

        Console.Write("Please, enter numeral systerm you to convert to (2<= d <=16): ");
        int d = int.Parse(Console.ReadLine());
        long decimalRepresantation = Convert.ToInt64(number, s);

        if (d == 10)
        {
            Console.WriteLine(decimalRepresantation);
        }
        else
        {
            string converted = ConvertNumber(decimalRepresantation, d);
            Console.WriteLine(converted);
        }
    }

    private static string ConvertNumber(long number, int endSystem)
    {
        StringBuilder result = new StringBuilder();
        long remainder = 0;
        while (number > 0)
        {
            remainder = number % endSystem;
            result.Insert(0, SwitchRemainder(remainder));
            number /= endSystem;
        }

        return result.ToString();
    }

    private static string SwitchRemainder(long remainder)
    {
        switch (remainder)
        {
            case 0:
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
                return remainder.ToString();
            case 10: return "A";
            case 11: return "B";
            case 12: return "C";
            case 13: return "D";
            case 14: return "E";
            case 15: return "F";
            default: throw new ArgumentOutOfRangeException("Invalid numeral system!");

        }
    }
}


