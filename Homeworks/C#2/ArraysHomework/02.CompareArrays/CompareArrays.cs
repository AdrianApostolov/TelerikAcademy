/*
 Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
 */


using System;
using System.Collections.Generic;
using System.Linq;

class CompareArrays
{
    static void Main()
   
    {
        Console.Write("Please, enter number of elements for first array: ");
        int firstArrayLength = int.Parse(Console.ReadLine());

        int[] firstArray = new int[firstArrayLength];

        for (int i = 0; i < firstArray.Length; i++)
			{
             Console.Write("Enter element[{0}] = ", i);
			 firstArray[i] = int.Parse(Console.ReadLine());
			}

        Console.Write("Please, enter number of elements for second array: ");
        int secondArrayLength = int.Parse(Console.ReadLine());

        int[] secondArray = new int[secondArrayLength];

        for (int i = 0; i < secondArray.Length; i++)
        {
            Console.Write("Enter element[{0}] = ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }
       
        bool isEqual = true;
        
        if (firstArrayLength == secondArrayLength)
        {
            for (int i = 0; i < firstArrayLength; i++)
       
            if (firstArray[i] == secondArray[i])
            {
                isEqual = true;
                
            }
            else
            {
                isEqual = false;
            }
        }
        else
            {
                isEqual = false;
            }
        
        Console.WriteLine("Equal: {0}", isEqual);
    }
}

