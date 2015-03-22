namespace IEnumerableExtensions
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class ExtensionMethods
    {
        public static T Sum<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T Product<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T Min<T>(this IEnumerable<T> collection)
        {
            dynamic min = decimal.MaxValue;

            foreach (var item in collection)
            {
                if (item < min)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T Max<T>(this IEnumerable<T> collection)
        {
            dynamic max = decimal.MinValue;

            foreach (var item in collection)
            {
                if (item > max)
                {
                    max = item;
                }
            }

            return (T)max;
        }

        public static T Average<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;
            
            foreach (var item in collection)
            {
                sum += item;
            }

            return (T)(sum / collection.Count());
        }
    }
}
