using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a number to convert");
        int input = int.Parse(Console.ReadLine());
        string number = null;
        while (input > 0)
        {
            if (input % 2 == 0)
            {
                number += "0";
            }
            else
            {
                number += "1";
            }

            input = input / 2;
        }
        char[] reversed = number.ToCharArray();
        Array.Reverse(reversed);
        Console.WriteLine(reversed);
    }
}

