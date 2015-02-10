using System;


class SumOfNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter count: ");
        int count = int.Parse(Console.ReadLine());
        if (count < 1)
        {
            Console.WriteLine("No numbers to sum.");
            return;
        }
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter number: ");
            sum += double.Parse(Console.ReadLine());

        }

        Console.WriteLine("The sum is: " + sum);
    }
}

