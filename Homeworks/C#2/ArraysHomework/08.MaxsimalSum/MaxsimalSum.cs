 /*
 Problem 8. Maximal sum

Write a program that finds the sequence of maximal sum in given array.
Example:

input	result
2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
Can you do it with only one loop (with single scan through the elements of the array)?
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MaxsimalSum
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

        int maxSum = numbersArray[0], currentSum = numbersArray[0];
        int start = 0, startTemp = 0, end = 0;

        for (int i = 1; i < numbersArray.Length; i++)
        {
            currentSum += numbersArray[i];
            if (currentSum < numbersArray[i])
            {
                currentSum = numbersArray[i];
                startTemp = i;
            }

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                start = startTemp;
                end = i;
            }

        }
        Console.Clear();

        Console.WriteLine("Array's elements: {0} ", string.Join(", ", numbersArray));
        Console.WriteLine(new string('-', 40));

        Console.WriteLine("Maximal sum: {0}", maxSum);
        Console.WriteLine(new string('-', 40));
       
        Console.Write("Sequence of maximal sum: ");
        for (int i = start; i <= end; i++)
        {
            Console.Write("{0} ", numbersArray[i]);
        }
        Console.WriteLine();
    }
}

