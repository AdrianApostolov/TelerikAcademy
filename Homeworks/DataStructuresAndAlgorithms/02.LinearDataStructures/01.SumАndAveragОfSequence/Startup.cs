/*
 1.Write a program that reads from the console a sequence of positive integer numbers.

The sequence ends when empty line is entered.
Calculate and print the sum and average of the elements of the sequence.
Keep the sequence in List<int>.
 */

namespace SumАndAveragОfSequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Utils;

    public class Startup
    {
        public static void Main()
        {
            var sequence = ConsoleUtility.GetSequence();

            if (sequence == null || sequence.Count == 0)
            {
                throw new ArgumentException("Sequence collection cannot be null or empty.");
            }

            PrintResult(sequence);
        }

        private static void PrintResult(ICollection<int> collection)
        {
            Console.WriteLine(collection.Sum());
            Console.WriteLine(collection.Average());
        }
    }
}
