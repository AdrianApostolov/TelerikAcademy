/*
 08. The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times.

Write a program to find the majorant of given array (if exists).
Example:
{2, 2, 3, 3, 2, 3, 4, 3, 3} → 3
 */

namespace FindTheMajorant
{
    using System;
    using System.Collections.Generic;
    using Utils;

    public class Program
    {
        public static void Main()
        {
            var collection = ConsoleUtility.GetSequence();
            var majorant = FindMajorant(collection);
            Console.WriteLine(majorant);
        }

        private static int FindMajorant(List<int> collection)
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

            var maxMajorant = 0;
            var currentMajorant = 0;
            var majorantNumer = 0;

            foreach (var item in dictionary)
            {
                if (item.Value >= (collection.Count / 2) + 1)
                {
                    currentMajorant = item.Value;
                }

                if (currentMajorant > maxMajorant)
                {
                    maxMajorant = currentMajorant;
                    majorantNumer = item.Key;
                }
            }

            return majorantNumer;
        }

    }
}
