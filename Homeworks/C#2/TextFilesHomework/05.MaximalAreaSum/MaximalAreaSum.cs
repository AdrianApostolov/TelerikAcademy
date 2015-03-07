/*
Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:

input	        output
4 
2 3 3 4           17
0 2 3 4 
3 7 1 2 
4 3 3 2	
*/


using System;
using System.IO;

namespace MaximalAreaSumPronlem
{
    class MaximalAreaSum
    {
        static int[,] ReadMatrix()
        {
            
            using (StreamReader reader = new StreamReader("Matrix.txt"))
            {
                int n = int.Parse(reader.ReadLine());
                int[,] matrix = new int[n, n];
                string rowInfo = string.Empty;

                for (int row = 0; row < n; row++)           
                {
                    rowInfo = reader.ReadLine();
                    string[] rowCells = rowInfo.Split(' ');
                    for (int col = 0; col < n; col++)
                    {
                        matrix[row, col] = int.Parse(rowCells[col]);
                    }
                }
                return matrix;
            }
        }

        static int MaxSum(int[,] matrix)
        {
            int maxSum = int.MinValue;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)     
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                    }
                }
            }
            return maxSum;
        }

        static void PrintResult(int maxSum)
        {
            using (StreamWriter result = new StreamWriter("Result.txt"))
            {
                result.WriteLine(maxSum);
            }
        }



        static void Main()
        {
            try
            {
                PrintResult(MaxSum(ReadMatrix()));
                Console.WriteLine("Max sum calculated!");
            }

            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Part of a file or directory cannot be found.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.DriveNotFoundException ex)
            {
                Console.WriteLine("Trying to access a drive or share that is not available.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.EndOfStreamException ex)
            {
                Console.WriteLine("Reading is attempted past the end of a stream.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.FileLoadException ex)
            {
                Console.WriteLine("Managed assembly is found but cannot be loaded.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Attempt to access a file that does not exist on disk fails.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.PathTooLongException ex)
            {
                Console.WriteLine("Path or file name is longer than the system-defined maximum length.");
                Console.WriteLine(ex.Message);
            }

            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("The program has no permissions to read the file!");
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("An unknown error occured!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
