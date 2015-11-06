// 5.Write a program that removes from given sequence all negative numbers.

namespace RemoveNegativeNumbers
{
    using System;
    using Utils;

    public class Startup
    {
        public static void Main()
        {
            var sequence = ConsoleUtility.GetSequence();

            sequence.ForEach(x =>
            {
                if (x >= 0)
                {
                    Console.WriteLine(x);
                }
            });
        }
    }
}
