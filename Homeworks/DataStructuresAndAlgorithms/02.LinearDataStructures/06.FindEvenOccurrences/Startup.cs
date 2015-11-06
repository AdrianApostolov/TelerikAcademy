/*
 06.Write a program that removes from given sequence all numbers that occur odd number of times.

Example:
{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} → {5, 3, 3, 5}
 */


namespace FindEvenOccurrences
{
    using System;
    using System.Linq;
    using Utils;

    public class Startup
    {
        public static void Main()
        {
            var sequence = ConsoleUtility.GetSequence();
            var result = sequence
                .Where(x => sequence.Count(y => y == x) % 2 == 0)
                .ToList();

            result.ForEach(x => Console.WriteLine(x));
        }
    }
}
