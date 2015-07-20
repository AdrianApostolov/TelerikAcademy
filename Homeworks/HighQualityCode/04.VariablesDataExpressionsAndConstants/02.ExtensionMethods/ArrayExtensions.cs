namespace ExtensionMethods
{
    using System;
    using System.Collections;
    using System.Linq;
    using System.Text;

    public static class ArrayExtensions
    {
        public static void PrintStatistics<T>(this T[] numbers)
             where T : IComparable
        {
            StringBuilder statistics = new StringBuilder();
            statistics.AppendFormat("Min number is: {0}", numbers.GetMin()).AppendLine();
            statistics.AppendFormat("Max number is: {0}", numbers.GetMax()).AppendLine();
            statistics.AppendFormat("Average number is: {0:F2}", numbers.GetAvg());

            Console.WriteLine(statistics);
        }

        public static T GetMin<T>(this T[] numbers)
            where T : IComparable
        {
            return numbers.Min();
        }

        public static T GetMax<T>(this T[] numbers)
            where T : IComparable
        {
            return numbers.Max();
        }

        public static T GetAvg<T>(this T[] numbers)
            where T : IComparable
        {
            dynamic sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }

            return (T)(sum / numbers.Length);
        }
    }
}
