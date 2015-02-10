using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Please, enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 1)
        {
            Console.WriteLine("The number is Odd.");
        }
        else
        {
            Console.WriteLine("The number is Even.");
        }
    }
}

