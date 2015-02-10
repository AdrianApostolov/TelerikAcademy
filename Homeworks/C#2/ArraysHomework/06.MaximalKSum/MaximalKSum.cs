/*
 Problem 6. Maximal K sum

Write a program that reads two integer numbers N and K and an array of N elements from the console.
Find in the array those K elements that have maximal sum.
 */


using System;
using System.Collections.Generic;
using System.Linq;

class MaximalKSum
{
    static void Main()
    {
        Console.Write("Please, enter number N of elements: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] arrayNumbers = new int[arrayLength];
        
        Console.Write("Please, entre number K for elements that have maximal sum: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Array element[{0}] = ", i);
            arrayNumbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(arrayNumbers);
        Array.Reverse(arrayNumbers);

        int sumElements = 0;
        for (int i = 0; i < k; i++)
        {
            sumElements += arrayNumbers[i];
        }

        Console.WriteLine("The sum of the greatest {0} numbers in the array is {1}.", k, sumElements);
    }
}

