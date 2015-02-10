using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Please, enter positive integer number N: ");
        int n = int.Parse(Console.ReadLine());
        while (n < 1 || n > 20)
        {
            Console.WriteLine("No correct number!");
            Console.Write("Please, enter positive integer number N: ");
            n = int.Parse(Console.ReadLine());
        }
        for (int row = 1; row <= n; row++)
        {
            for (int column = row; column < row + n; column++)
            {
                Console.Write("{0,-2} ", column);
            }
            Console.WriteLine();
        }
    }
}
