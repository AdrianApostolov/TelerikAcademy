using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.WriteLine("Please, enter three integer numbers for N, MIN and MAX");
        Console.Write("Please, enter intege number for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter intege number for MIN: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Please, enter intege number for MAX: ");
        int max = int.Parse(Console.ReadLine());

        while (min == max)
        {
            Console.WriteLine("Incorrect input, please enter (min != max)");
            Console.Write("Please, enter intege number for N: ");
            n = int.Parse(Console.ReadLine());
        }
        Random r = new Random();
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", r.Next(min, max + 1));
        }
    }
}

