/*
Problem 1. Fill the matrix
Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:
a)               b)              c)              d)
 1	5	9	13    1	8	9	16    7	11	14	16   1	12	11	10
 2	6 10	14   2	7	10	15   4	8	12	15    2	13	16	9
 3	7	11	15   3	6	11	14   2	5	9	13     3	14	15	8
 4	8	12	16   4	5	12	13   1	3	6	10     4	5	6	7
*/

using System;
using System.Linq;

class ProgramFillTheMatrix
{
    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                Console.Write("{0,-4}", matrix[rows, columns]);
            }
            Console.WriteLine();
        }
    }
   
    
    static void Main()
    {
        Console.Write("Please, enter number for n: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        Console.Write("Please, choice in which case would you want to fill the matrix (a, b, c): ");
        char choice = char.Parse(Console.ReadLine());

        switch (choice)
        {
            case 'a':

                for (int columns = 0, index = 1; columns < matrix.GetLength(1); columns++)
                {
                    for (int rows = 0; rows < matrix.GetLength(0); rows++, index++)
                    {
                        matrix[rows, columns] = index;
                    }
                }

                PrintMatrix(matrix, n);
                break;


            case 'b':

                for (int columns = 0; columns < matrix.GetLength(1); columns++)
                {
                    for (int rows = 0; rows < matrix.GetLength(0); rows++)
                    {
                        if (columns % 2 == 0)
                        {
                            matrix[rows, columns] = rows + 1 + (columns * n);
                        }
                        else
                        {
                            matrix[n - 1 - rows, columns] = rows + 1 + (columns * n);
                        }
                    }
                }
                PrintMatrix(matrix, n);
                break;

            case 'c':
               
                int value = 1;
                // fill matrix under the main diagonal
                for (int i = n - 1; i >= 0; i--)
                {
                   int rows = i;
                   int columns = 0;
                   while (rows < n && columns < n)
                    {
                        matrix[rows, columns] = value;
                        rows++;
                        columns++;
                        value++;
                    }
                }
                // fill matrix over the main diagonal
                for (int j = 1; j < n; j++)
                {
                    int rows = 0;
                    int columns = j;
                    while (rows < n && columns < n)
                    {
                        matrix[rows, columns] = value;
                        rows++;
                        columns++;
                        value++;
                    }
                }

                PrintMatrix(matrix, n);
                break;
        }
    }

}

