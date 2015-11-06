/*
 09.We are given the following sequence:

    S1 = N;
    S2 = S1 + 1;
    S3 = 2*S1 + 1;
    S4 = S1 + 2;
    S5 = S2 + 1;
    S6 = 2*S2 + 1;
    S7 = S2 + 2;
    ...
    Using the Queue<T> class write a program to print its first 50 members for given N.
    Example: N=2 → 2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
 */

namespace PrintFirstFiftyMembers
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Enter integer number: ");
            var userInput = int.Parse(Console.ReadLine());

            var findMembers = FindNextMemebers(userInput, 50);
            Console.WriteLine(string.Join(", ", findMembers));
        }

        private static List<int> FindNextMemebers(int startNumber, int sequeceLength)
        {
            var result = new List<int>();
            var queue = new Queue<int>();

            queue.Enqueue(startNumber);
            result.Add(startNumber);

            for (int i = 0; i < sequeceLength; i++)
            {
                var firstMember = queue.Dequeue();

                foreach (var operation in operations)
                {
                    var nextMember = operation(firstMember);
                    queue.Enqueue(nextMember);
                    result.Add(nextMember);
                }
            }

            return result;
        }

        private static Func<int, int>[] operations =
        {
            x => x + 1,
            x => 2 * x + 1,
            x => x + 2,
        };
    }
}
