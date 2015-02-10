/*
 Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:

      input	            result
3, 2, 3, 4, 2, 2, 4  	2, 3, 4
 */


using System;
using System.Collections.Generic;
using System.Linq;

class MaxIncreasingSequence
{
    static void Main()
    {
        Console.Write("Enter number of elements: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] arrayNumbers = new int[arrayLength];
        int maxSequence = 0;
        int currentSequence = 1;
        int sequenceStart = 0;
        for (int i = 0; i < arrayLength; i++)
        {
            Console.Write("Enter element[{0}]: ", i);
            arrayNumbers[i] = int.Parse(Console.ReadLine());
            if (i != 0)
            {
                if (arrayNumbers[i] - 1 == arrayNumbers[i - 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    sequenceStart = i + 1 - maxSequence;
                }
            }
        }

        Console.Write("The maximal sequence of equal elements is: ");
        for (int i = sequenceStart; i < sequenceStart + maxSequence; i++)
        {
            Console.Write("{0} ", arrayNumbers[i]);

        }
    }
}

