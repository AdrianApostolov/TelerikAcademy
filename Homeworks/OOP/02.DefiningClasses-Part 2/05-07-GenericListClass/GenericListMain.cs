/*
Problem 5. Generic class

Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString().
Check all input parameters to avoid accessing elements at invalid positions.

Problem 6. Auto-grow

Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.

Problem 7. Min and Max

Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
You may need to add a generic constraints for the type T.
*/

namespace GenericList
{
    using System;

    class GenericListMain
    {
        static void Main()
        {
            GenericList<int> testList = new GenericList<int>(5);

            ////testing Add method and Capacity
            for (int i = 0; i < 20; i++) 
            {
                testList.Add(i + 1);
                Console.WriteLine("Element: {0}, Count: {1} Capacity: {2}", testList[i], testList.Count, testList.Capacity);
            }

            ////testing Insert method and Remove method
            for (int i = 0; i < testList.Count; i += 3) 
            {
                testList.Insert(i, 3);
            }

            for (int i = 0; i < testList.Count; i += 4)
            {
                testList.Remove(i);
            }
            ////testing ToString method
            Console.WriteLine(testList);

            ////testing T Min method
            Console.WriteLine("Min: {0}", testList.Min());

            ////testing T Max method
            Console.WriteLine("Max: {0}", testList.Max()); 
        }
    }
}
