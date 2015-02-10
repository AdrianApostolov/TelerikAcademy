using System;

class MinMaxSumAverageOfNumbers
{
    static void Main()
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        long sum = 0;

        Console.Write("Please, enter interger number of sequence of numbers: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine("Enter the {0} number: ", i);
            int input = int.Parse(Console.ReadLine());

            if (input > max)
            {
                max = input;
            }
            if (input < min)
            {
                min = input;
            }
            sum += input;
        }

        double average = sum / count;

        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, average);

    }
}
