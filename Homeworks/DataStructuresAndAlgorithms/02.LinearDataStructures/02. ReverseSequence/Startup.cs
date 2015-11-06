/*
 2.Write a program that reads N integers from the console and reverses them using a stack.

Use the Stack<int> class.
 */

namespace ReverseSequence
{
    using System;
    using System.Collections.Generic;
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

            var result = new List<int>();
            var stack = new Stack<int>();

            sequence.ForEach(x => stack.Push(x));

            foreach (var item in stack)
            {
                result.Add(item);
            }

            result.ForEach(x => Console.WriteLine(x));
        }
    }
}
