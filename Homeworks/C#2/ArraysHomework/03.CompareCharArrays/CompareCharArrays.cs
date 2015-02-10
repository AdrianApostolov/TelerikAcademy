/*
 Problem 3. Compare char arrays

Write a program that compares two char arrays lexicographically (letter by letter).
 */


using System;
using System.Collections.Generic;
using System.Linq;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Please, enter length for the first char array: ");
        int firstCharArrayLength = int.Parse(Console.ReadLine());

        char[] firstCharArray = new char[firstCharArrayLength];

        for (int i = 0; i < firstCharArrayLength; i++)
        {
            Console.Write("Enter elements[{0}] = ", i);
            firstCharArray[i] = char.Parse(Console.ReadLine());
        }


        Console.Write("Please, enter length for the second char array: ");
        int secondCharArrayLength = int.Parse(Console.ReadLine());

        char[] secondCharArray = new char[secondCharArrayLength];

        for (int i = 0; i < secondCharArrayLength; i++)
        {
            Console.Write("Enter element[{0}] = ", i);
            secondCharArray[i] = char.Parse(Console.ReadLine());
        }

        bool isCharEqual = true;
        if (firstCharArrayLength == secondCharArrayLength)
        {
            for (int i = 0; i < firstCharArrayLength; i++)
            {
                if (firstCharArray[i] == secondCharArray[i])
                {
                    isCharEqual = true;
                }
                else
                {
                    isCharEqual = false;
                }
            }
        }
        else
        {
            isCharEqual = false;
        }
        Console.WriteLine("Is char equal: {0}", isCharEqual);
    }
}

