/*
Problem 4. Appearance count

Write a method that counts how many times given number appears in given array.
Write a test program to check if the method is workings correctly.
*/


using System;
using System.Collections.Generic;
using System.Linq;
class AppearanceCount
{
    static int CountElementAppearance(int[] array , int number) 
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
            
        }
        return counter;
    }


    static void Main()
    {
        int[] arrayNumbers = { 3, 4, 6, 7, 2, 4, 4, 5 };
        //int[] arrayNumbers = { 1, 2, 2, 7, 2, 4, 3 5 };
        //int[] arrayNumbers = { 6 2, 6, 3, 2, 4, 4, 5 };
        //int[] arrayNumbers = { 10, 4, 9, 7, 8 4, 4, 9 };

        Console.Write("Enter number to search for: ");
        int givenNumber = int.Parse(Console.ReadLine());
        int count = CountElementAppearance(arrayNumbers, givenNumber);
        Console.WriteLine("{0} appears {1} times in the array", givenNumber, count);
    }
}

