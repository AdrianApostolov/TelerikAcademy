namespace RefactorExam
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class SumOfDifferences
    {
        public static void Main()
        {
            string readInput = Console.ReadLine();

            string[] input = readInput.Split(new char[] { ' ', ',', '.', '/' }, StringSplitOptions.RemoveEmptyEntries);

            var numbers = new List<BigInteger>();
            
            // Parsing all numbers
            for (int i = 0; i < input.Length; i++)
            {
                numbers.Add(BigInteger.Parse(input[i]));
            }

            var absoluteDifference = new List<BigInteger>();

            BigInteger difference = 0;

            for (int i = 1; i < numbers.Count; i++)
            {
                decimal max = Math.Max((decimal)numbers[i], (decimal)numbers[i - 1]);
                decimal min = Math.Min((decimal)numbers[i], (decimal)numbers[i - 1]);

                difference = (BigInteger)Math.Abs(max - min);

                absoluteDifference.Add(difference);

                if (difference % 2 != 0)
                {
                    continue;
                }
                else if (difference % 2 == 0)
                {
                    i++;
                }

                if (i >= numbers.Count)
                {
                    break;
                }
            }

            BigInteger sum = 0;

            for (int i = 0; i < absoluteDifference.Count; i++)
            {
                if (absoluteDifference[i] % 2 != 0)
                {
                    sum += absoluteDifference[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}