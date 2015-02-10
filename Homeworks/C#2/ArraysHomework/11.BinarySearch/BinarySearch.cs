/*
 Problem 11. Binary search

Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.
*/


using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please, enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] binarrySearchedArray = new int[n];

        for (int i = 0; i < binarrySearchedArray.Length; i++)
        {
            Console.Write("Enter element[{0}]: ", i);
            binarrySearchedArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please enter searched number: ");
        int searchedNumber = int.Parse(Console.ReadLine());

        int start = 0;
        int end = binarrySearchedArray.Length-1;

        while ((end - start) > 1)
        {
            int index = start + (end - start) / 2;

            if (binarrySearchedArray[index] == searchedNumber) 
            { 
                Console.WriteLine("{0} is at position {1}", searchedNumber, index); 
                return; 
            }
            else if (binarrySearchedArray[index] > searchedNumber)
            {
                end = index;
            }
            else if (binarrySearchedArray[index] < searchedNumber)
            {
                start = index;
            }
        }
        Console.WriteLine("Not found!");

    }
}

