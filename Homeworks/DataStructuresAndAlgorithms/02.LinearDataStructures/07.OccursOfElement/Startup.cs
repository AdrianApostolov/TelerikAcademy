/*
 7. Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.

    Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
    2 → 2 times
    3 → 4 times
    4 → 3 times
 */

namespace OccursOfElement
{
    using System;
    using System.Collections.Generic;
    using Utils;

    public class Startup
    {
        public static void Main()
        {
            var sequence = ConsoleUtility.GetSequence();
            var occurrences = FindElementsOccurrences(sequence);

            PrintResult(occurrences);
        }

        private static Dictionary<int, int> FindElementsOccurrences(List<int> collection)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (!dictionary.ContainsKey(collection[i]))
                {
                    dictionary[collection[i]] = 0;
                }

                dictionary[collection[i]]++;
            }

            return dictionary;
        }

        private static void PrintResult(Dictionary<int, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1} time(s).", item.Key, item.Value);
            }
        }
    }
}
