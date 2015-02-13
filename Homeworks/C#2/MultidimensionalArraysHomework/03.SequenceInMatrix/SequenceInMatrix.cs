/*
Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
*/


using System;
using System.Collections.Generic;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        Console.Write("Please, enter size N of the matrix: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Please, enter size M of the matrix: ");
        int m = int.Parse(Console.ReadLine());

        string[,] matrix = new string[n, m];

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int columns = 0; columns < matrix.GetLength(1); columns++)
            {
                Console.Write("Element of array[{0},{1}]: ", rows, columns);
                matrix[rows, columns] = Console.ReadLine();
            }
        }

        int currElement = 0;
        int maxElement = 0;
        string longSequence = "";

        // Horizontally search

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)     
            {
                if ((matrix[row, col] == matrix[row, col + 1]))
                {
                    currElement++;
                }
                else
                {
                    currElement = 1;
                }
                if (currElement > maxElement)
                {
                    maxElement = currElement;
                    longSequence = matrix[row, col];
                    
                }
            }
            currElement = 1;
        }

        // Vertically search

        for (int col = 0; col < matrix.GetLength(1); col++)                 
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if ((matrix[row, col] == matrix[row + 1, col]))
                {
                    currElement++;
                }
                else
                {
                    currElement = 1;
                }
                if (currElement > maxElement)
                {
                    maxElement = currElement;
                    longSequence = matrix[row, col];
                    
                }
            }
            currElement = 1;
        }

        // Diagonally search

        for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
        {
            if ((matrix[row, col] == matrix[row + 1, col + 1]))
            {
                currElement++;
            }
            else
            {
                currElement = 1;
            }
            if (currElement > maxElement)
            {
                maxElement = currElement;
                longSequence = matrix[row, col];
             
            }
        }
        Console.Write("The longest sequence of equal strings is: ");
        for (int i = 0; i < maxElement; i++)
        {
            Console.Write(longSequence + ", ");
        }
    }
}

