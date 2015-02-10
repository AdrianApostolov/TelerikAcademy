using System;

class TrailingZeroes
{
    static void Main()
    {
        Console.Write("Please, enter integer number N: ");
        int n = int.Parse(Console.ReadLine());

        int trailingZero = 0;

        for (int power5 = 5; power5 <= n; power5 *= 5)
        {
            trailingZero += n / power5;
        }

        Console.WriteLine("{0}! has {1} trailing zeros"
                            , n, trailingZero);
    }
}

