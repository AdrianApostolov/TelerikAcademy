/*
 3.Write a program that reads a sequence of integers (List<int>) ending with an empty line 
 and sorts them in an increasing order.
 */

namespace SortInputElements
{
    using System;
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

            sequence.Sort();
            sequence.ForEach(x => Console.WriteLine(x));
        }
    }
}
