/*
 Problem 10. Find sum in array

Write a program that finds in given array of integers a sequence of given sum S (if present).
Example:

        array	       S	result
4, 3, 1, 4, 2, 5, 8	   11	4, 2, 5
*/


using System;
using System.Collections.Generic;
using System.Linq;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Please, enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter element[{0}]: ", i);
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter sum S: ");
        int enterSum = int.Parse(Console.ReadLine());
        int sum = 0;
        bool availableSum = false;


        for (int i = 0; i < numbersArray.Length; i++)
        {
            for (int j = i; j < numbersArray.Length; j++)
            {
                sum += numbersArray[j];
                if (sum == enterSum)
                {
                    availableSum = true;
                    Console.Write("The following sequence has the sum of {0}: ", sum);
                    for (int print = i; print <= j; print++)
                    {
                        Console.Write("{0} ", numbersArray[print]);
                    }
                    Console.WriteLine();
                }
               
            }
            sum = 0;
        }
        if (!availableSum)
        {
            Console.WriteLine("Ain't no sequnce with the sum of {0}!", sum);
        }
    }
}

