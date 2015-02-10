using System;

class NumbersOneToN
{
    static void Main()
    {
        Console.Write("Please, enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 0; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}

