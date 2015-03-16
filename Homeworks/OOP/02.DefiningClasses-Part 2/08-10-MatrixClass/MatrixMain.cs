/*
Problem 8. Matrix

Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
Problem 9. Matrix indexer

Implement an indexer this[row, col] to access the inner matrix cells.
Problem 10. Matrix operations

Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
Throw an exception when the operation cannot be performed.
Implement the true operator (check for non-zero elements).
*/ 

namespace MatrixClass
{
    using System;

    public class MatrixMain
    {
        public static readonly Random Random = new Random();

        public static void Main()
        {
            Matrix<int> firstMatrix = new Matrix<int>(3, 3);

            for (int row = 0; row < firstMatrix.Rows; row++)
            {
                for (int col = 0; col < firstMatrix.Cols; col++)
                {
                    firstMatrix[row, col] = Random.Next(10);
                }
            }

            Matrix<int> secondMatrix = new Matrix<int>(3, 3);

            for (int row = 0; row < secondMatrix.Rows; row++)
            {
                for (int col = 0; col < secondMatrix.Cols; col++)
                {
                    secondMatrix[row, col] = Random.Next(10);
                }
            }

            Console.WriteLine("First Matrix ({0}x{1}) is:", firstMatrix.Rows, firstMatrix.Cols);
            Console.WriteLine(firstMatrix);

            Console.WriteLine("Second Matrix ({0}x{1}) is:", secondMatrix.Rows, secondMatrix.Cols);
            Console.WriteLine(secondMatrix);

            Console.WriteLine("Addition of the Matrices:");
            Console.WriteLine(firstMatrix + secondMatrix);

            Console.WriteLine("Subtraction of the Matrices:");
            Console.WriteLine(firstMatrix - secondMatrix);

            Console.WriteLine("Multiplication of the Matrices:");
            Console.WriteLine(firstMatrix * secondMatrix);

            Console.WriteLine("First matrix: {0}", firstMatrix ? "Non-empty!" : "Empty!");
            Console.WriteLine("New matrix: {0}" + Environment.NewLine, new Matrix<int>(1, 1) ? "Non-empty!" : "Empty!");
        }
    }
}
