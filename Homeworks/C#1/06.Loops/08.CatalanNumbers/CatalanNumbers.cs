using System;
using System.Numerics;
class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter value of N (1 < N < 100): ");
        int n = int.Parse(Console.ReadLine());

        while (n <= 1 || n >= 100)
        {
            Console.WriteLine("No correct number!");
            Console.Write("Enter value of N (1 < N < 100): ");
            n = int.Parse(Console.ReadLine());
        }
        
        BigInteger firstFactoriel = 1;
        BigInteger secondFactoriel = 1;
        BigInteger thirdFactoriel = 1;

        for (int i = 1; i <= 2*n; i++)
        {
            firstFactoriel *= i;
        }
        for (int i = 1; i <= n + 1; i++)
        {
            secondFactoriel *= i;
        }
        for (int i = 1; i <= n ; i++)
        {
            thirdFactoriel *= i;
        }

        BigInteger result = firstFactoriel / (secondFactoriel * thirdFactoriel);
        Console.WriteLine("Catalan(n): " + result);
    }
}
