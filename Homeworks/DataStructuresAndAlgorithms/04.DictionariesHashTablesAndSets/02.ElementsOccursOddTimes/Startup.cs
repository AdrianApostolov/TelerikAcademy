namespace ElementsOccursOddTimes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    class Startup
    {
        static void Main()
        {
            var input = ReadInput();
            var result = FindOddOccurrences(input);
            PrintResult(result);
        }

        private static IDictionary<string, int> FindOddOccurrences(IEnumerable<string> collection)
        {
            var result = new Dictionary<string, int>();

            foreach (var item in collection)
            {
                if (!result.ContainsKey(item))
                {
                    result[item] = 0;
                }

                result[item]++;
            }

            return result;
        }

        static IEnumerable<string> ReadInput()
        {
            var input = new StringReader("C#, SQL, PHP, PHP, SQL, SQL ");
            Console.SetIn(input);

            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            return inputNumbers;
        }

        static void PrintResult(IDictionary<string, int> dict)
        {
            var result = dict
                .Where(x => x.Value % 2 != 0)
                .ToArray();

            Console.Write("Odd occurs is: ");
            foreach (var pair in result)
            {
                Console.Write(pair.Key + " ");
            }

            Console.WriteLine();
        }
    }
}
