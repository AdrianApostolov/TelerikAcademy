using System;

class NumbersNotDivisibleByThreeAndSeven
{
    static void Main()
    {
        Console.Write("Please, enter positive integer number: ");
        int number = int.Parse(Console.ReadLine());

        while (number <= 0)
        {
            Console.WriteLine("No correct number!");
            Console.Write("Please, enter positive integer number: ");
            number = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i <= number; i++)
        {
            if (i % 3 != 0 && i % 7 != 0)
            Console.Write(i + " ");
        }

    }
}
