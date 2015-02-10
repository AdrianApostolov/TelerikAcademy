using System;

class NumbersFromOneToN
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
                Console.Write(i + " ");
            }
            Console.WriteLine();
    }
}

