using System;
using System.Numerics;

class CalculateFacturielDivision
{
    static void Main()
    {
        Console.WriteLine("Please, enter two integer numbers: ");
        Console.Write("Please, enter integer number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter integer number K: ");
        int k = int.Parse(Console.ReadLine());

        while ((1 > k) || (k > n) || (n > 100))
        {
            Console.WriteLine("No correct number!");
            Console.Write("Please, enter integer number N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Please, enter integer number K: ");
            k = int.Parse(Console.ReadLine());
        }
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;

        for (int i =k + 1; i <= n; i++)
        {
            factorielN *= i;
            if (i <= k)
            {
                factorielK *= i;
            }
        }
        BigInteger result =(BigInteger)(factorielN / factorielK);
        Console.WriteLine("N!/!K = " + result);
    }
}

