/*
Problem 4. Binary search

Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.
*/


using System;
using System.Collections.Generic;
using System.Linq;

class BinarySearch
{
    static void Main(string[] args)
    {
         Console.Write("Please, enter integer number N for size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Please, enter element[{0}]", i);
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please, enter integer number K: ");
        int k = int.Parse(Console.ReadLine());

        
        Array.Sort(array);

        if (array[0] > k)
        {
            Console.WriteLine("There is no number that is less than or equal to k.");
        }
        
        while (Array.BinarySearch(array, k) < 0)
        {
            k--;
        }

        Console.WriteLine("Largest number in the array which is less or equal to K is " + k);
    }
}

