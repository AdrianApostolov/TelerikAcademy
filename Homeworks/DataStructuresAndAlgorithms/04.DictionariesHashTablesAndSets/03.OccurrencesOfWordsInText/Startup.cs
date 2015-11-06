namespace OccurrencesOfWordsInText
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Startup
    {
        static readonly char[] separators = new char[] { '.', ',', '!', ' ', '/', '-', ':', ';', '?', '"', '\'', '&', '–' };

        static void Main(string[] args)
        {
            var input = ReadInput();
            var result = FindOccurrences(input);
            PrintResult(result);
        }


        private static IDictionary<string, int> FindOccurrences(IEnumerable<string> collection)
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
            var input = File.ReadAllText("../../Dijkstra's algorithm.txt")
                 .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                 .Select(x => x.ToLower())
                 .ToArray();

            return input;
        }

        static void PrintResult(IDictionary<string, int> dict)
        {
            var result = dict.OrderBy(x => x.Value);

            foreach (var pair in result)
            {
                Console.WriteLine("{0} -> {1}", pair.Key, pair.Value);
            }
        }
    }
}
