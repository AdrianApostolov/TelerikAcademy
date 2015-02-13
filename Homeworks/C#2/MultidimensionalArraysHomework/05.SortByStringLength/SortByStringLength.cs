/*
Problem 5. Sort by string length

You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).
*/


using System;
using System.Collections.Generic;
using System.Linq;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Please, enter size of string array: ");
        int size = int.Parse(Console.ReadLine());

        string[] array = new string[size];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Please, enter element[{0}]: ", i);
            array[i] = Console.ReadLine();
        }

        // With lambda expressions
        Array.Sort(array, (x, y) => x.Length.CompareTo(y.Length));
        Console.WriteLine("Sorted array is: ");
        foreach (string elements in array)
        {
            Console.WriteLine(elements);
        }

        // With Selection sort
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (array[i].Length > array[j].Length)
                {
                    string temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("Sorted array is: ");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(array[i] + " ");
        }
        Console.WriteLine();

    }
}

