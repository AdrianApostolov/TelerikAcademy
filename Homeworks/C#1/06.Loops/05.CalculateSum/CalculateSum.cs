using System;

class CalculateSum
{
    static void Main()
    {
        Console.WriteLine("Please, enter two integer numbers.");
        Console.Write("Please, enter integer number N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please, enter integer number X: ");
        int x = int.Parse(Console.ReadLine());
        
        double sum = 1;
        decimal factoriel = 1;
        
        for (int i = 1; i <= n ; i++)
        {
            factoriel *= i;
            sum += (double)factoriel / Math.Pow(x, i);
        }
        Console.WriteLine("The Sum is: {0:F5} ", sum);
    }
}
