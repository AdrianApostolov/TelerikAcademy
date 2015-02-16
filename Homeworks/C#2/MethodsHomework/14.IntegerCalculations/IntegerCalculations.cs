/*
Problem 14. Integer calculations

Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
Use variable number of arguments.
*/ 


using System;

class IntegerCalculations
{
    static int Product(int[] sequence)
    {
        int product = 1;

        for (int i = 0; i < sequence.Length; i++)
        {
            product *= sequence[i];
        }
        return product;
    }

    static int Sum(int[] sequence)
    {
        int sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum;
    }

    static double Average(int[] sequence)
    {
        double sum = 0;
        for (int i = 0; i < sequence.Length; i++)
        {
            sum += sequence[i];
        }
        return sum / sequence.Length;
    }

    static int Max(int[] sequence)
    {
        int max = int.MinValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] > max)
            {
                max = sequence[i];
            }
        }
        return max;
    }

    static int Min(int[] sequence)
    {
        int min = int.MaxValue;
        for (int i = 0; i < sequence.Length; i++)
        {
            if (sequence[i] < min)
            {
                min = sequence[i];
            }
        }
        return min;
    }
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] input = new int[n];

        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            input[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sum: " + Sum(input));
        Console.WriteLine("Min: " + Min(input));
        Console.WriteLine("Max: " + Max(input));
        Console.WriteLine("Average: " + Average(input));
        Console.WriteLine("Product: " + Product(input));
    }
}

