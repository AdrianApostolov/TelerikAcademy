/*
Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/


using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please, enter size N of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please, enter size M of the matrix: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                Console.Write("Element of array[{0},{1}]", rows, columns);
                matrix[rows, columns] = int.Parse(Console.ReadLine());
            }
        }


        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                Console.Write("{0,-4}", matrix[rows, columns]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();


        
        int bestSum = int.MinValue;
        for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1) - 2; columns++)
            {
                int sum = matrix[rows, columns] + matrix[rows, columns + 1] + matrix[rows, columns + 2]

                    + matrix[rows + 1, columns] + matrix[rows + 1, columns + 1] + matrix[rows + 1, columns + 2]

                    + matrix[rows + 2, columns] + matrix[rows + 2, columns + 1] + matrix[rows + 2, columns + 2];

                if (sum > bestSum)
                    bestSum = sum;
            }
        }
        Console.WriteLine("Maximal sum of the square 3 x 3 is: {0}", bestSum);
    }
}

