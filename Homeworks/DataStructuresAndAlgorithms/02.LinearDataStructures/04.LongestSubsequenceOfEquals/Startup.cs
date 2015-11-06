/*
 4.Write a method that finds the longest subsequence of equal numbers in given List and returns the result as new List<int>.

Write a program to test whether the method works correctly.
 */

namespace LongestSubsequenceOfEquals
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

            var result = FindLongestSubseqience(sequence);

            result.ForEach(x => Console.WriteLine(x));

        }

        public static List<int> FindLongestSubseqience(IList<int> sequence)
        {
            var result = new List<int>();
            int maxSequence = 0;
            int currentSequence = 1;
            int sequenceStart = 0;

            for (int i = 1; i < sequence.Count; i++)
            {
                if (sequence[i] == sequence[i - 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }

                if (currentSequence > maxSequence)
                {
                    maxSequence = currentSequence;
                    sequenceStart = i + 1 - maxSequence;
                }
            }

            for (int i = sequenceStart; i < sequenceStart + maxSequence; i++)
            {
                result.Add(sequence[i]);
            }

            return result;
        }
    }
}
