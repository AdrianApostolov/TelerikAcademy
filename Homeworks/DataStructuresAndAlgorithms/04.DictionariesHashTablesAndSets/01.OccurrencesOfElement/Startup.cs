namespace OccurrencesOfElement
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
            var result = FindOccurrences(input);
            PrintResult(result);
        }

        private static IDictionary<double, int> FindOccurrences(IEnumerable<double> collection)
        {
            var result = new Dictionary<double, int>();

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

        static IEnumerable<double> ReadInput()
        {
            var input = new StringReader("3, 4, 4, -2.5, 3, 3, 4, 3, -2.5");
            Console.SetIn(input);

            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => double.Parse(x))
                .ToList();

            return inputNumbers;
        }

        static void PrintResult(IDictionary<double, int> dict)
        {
            foreach (var pair in dict)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
