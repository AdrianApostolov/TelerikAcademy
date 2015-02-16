/*
Problem 5. Larger than neighbours

Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).
*/


using System;

class LargerThanNeighbours
{
    static bool CheckIfLargerThanNeighbours(int[] array, int position)
    {
        if (position < array.Length - 1 && position > 0)
        { 
            if ((array[position] > array[position + 1]) && (array[position] > array[position - 1]))
            {
                return true;
            }
        }
        return false;
    }


    static void Main()
    {
        Console.Write("Please, enter number for size of array: ");
        int size = int.Parse(Console.ReadLine());

        int[] arrayNumbers = new int[size];
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            Console.Write("Please, enter element[{0}]:", i);
            arrayNumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Please, enter a position that we are going to analyze: ");
        int positionNumber = int.Parse(Console.ReadLine());
        while (positionNumber < 0 || positionNumber >= size) 
        {
            Console.WriteLine("Wrong position! Please try again.");
            Console.Write("Please, enter a position that we are going to analyze: ");
            positionNumber = int.Parse(Console.ReadLine());
        }
        
        bool result = CheckIfLargerThanNeighbours(arrayNumbers, positionNumber);
        Console.WriteLine("Larger than neighbors: {0}", result);
    }
}

