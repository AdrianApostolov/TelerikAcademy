/*
 Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Please, enter number of elements: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] arrayNumber = new int[arrayLength];
        
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Array element[{0}] = ", i);
            arrayNumber[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < arrayLength - 1; i++)
        {
            for (int j = i + 1; j < arrayLength; j++)
            {
                if (arrayNumber[i] > arrayNumber[j])
                {
                    int temp = arrayNumber[i];
                    arrayNumber[i] = arrayNumber[j];
                    arrayNumber[j] = temp;
                }
            }
        }
        Console.WriteLine();
        Console.Write("Sorted array is: ");
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write(arrayNumber[i] + " ");
        }
        Console.WriteLine();
    }
}

