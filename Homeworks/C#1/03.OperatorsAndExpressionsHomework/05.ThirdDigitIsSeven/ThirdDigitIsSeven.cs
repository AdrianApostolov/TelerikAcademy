using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Please, enter number: ");
        int number = int.Parse(Console.ReadLine());

        bool check = (number / 100) % 10 == 7;
        Console.WriteLine("The third digit (right-to-left) of " + number + " is 7 ===> " + check);
    }
}

