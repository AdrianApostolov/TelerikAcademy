/*
Problem 6. First larger than neighbours

Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
Use the method from the previous exercise.
*/


using System;

class FirstLargerThanNeighbours
{
    static int CheckIfLargerThanNeighbours(int[] array)
    {
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {

            if (i < array.Length - 1 && i > 0)
            {
                if ((array[i] > array[i + 1]) && (array[i] > array[i - 1]))
                {
                    index = i;
                }

            }
        }
        return index; 
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

         int result = CheckIfLargerThanNeighbours(arrayNumbers);
        Console.WriteLine("Index of the first element in array that is larger than its neighbours: {0}", result);
    }
}

