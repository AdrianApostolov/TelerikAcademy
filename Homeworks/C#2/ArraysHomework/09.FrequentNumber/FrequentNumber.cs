/*
 Problem 9. Frequent number

Write a program that finds the most frequent number in an array.
Example:

                input	                   result
4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	 4(5 times)
 */ 


using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
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
        
        int maxCount = 0, count = 1, number = 0;

        if (numbersArray.Length == 1)
        {
            maxCount = 1;
            number = numbersArray[0];
        }

        Array.Sort(numbersArray);

        for (int i = 1; i < numbersArray.Length; i++)
        {
            if (numbersArray[i] == numbersArray[i - 1])
            {
                count++;
            }
            else
            {
                count = 1;
            }

            if (count > maxCount)
            {
                maxCount = count;
                number = numbersArray[i];
            }
        }
        Console.WriteLine();
        Console.WriteLine("{0} ({1} times)", number, maxCount);
        
    }
}

