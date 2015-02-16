/*
Problem 9. Sorting array

Write a method that return the maximal element in a portion of array of integers starting at given index.
Using it write another method that sorts an array in ascending / descending order.
*/ 


using System;

class SortingArray
{
    
    static int GetMaxElement(int[] array, int index, bool ascending = true)
    {

        int maxIndex = index;
        for (index++; index < array.Length; index++)
        {
            if (ascending)
            {
                if (array[index] < array[maxIndex])
                {
                    maxIndex = index;
                }
            }
            else
            {
                if (array[index] > array[maxIndex])
                {
                    maxIndex = index;
                }
            }
        }
        return maxIndex;
    }

    static void Sort(int[] array, bool ascdeing = true)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Swap(array, i, GetMaxElement(array, i, ascdeing));
        }
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + (i == array.Length - 1 ? "\n" : " "));
        }
    }
    static void Main()
    {

        int[] array = { 7, 3, 46, -9, -12, 32};
                    //{ -1, 6, 23, -44, 12, -18 };
                    //{ -12, 28, 2, -6, 11, 0 };
                    //{ 8, 3, 1, -5, 33, -15 };
        // ascending order
        Sort(array);
        Print(array);
        
        // descending order
        Sort(array, false);
        Print(array);

    }
}

