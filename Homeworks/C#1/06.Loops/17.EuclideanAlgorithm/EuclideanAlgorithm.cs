using System;

class EuclideanAlgorithm
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.WriteLine("GCD: " + GCD(first, second));
    }

    static int GCD(int a, int b)
    {
        int remainder;

        while (b != 0)
        {
            remainder = a % b;
            a = b;
            b = remainder;
        }

        return a;
    }
}
