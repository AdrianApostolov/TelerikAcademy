namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    class IEnumerableExtensionsMain
    {
        public static void Main()
        {
            List<int> list = new List<int> { 4, 5, 10, 22, 7, 2, 13 };

            Console.WriteLine(string.Join(", ", list));
            

            Console.WriteLine("Sum of elements: {0}", list.Sum());
            
            Console.WriteLine("Product of elements: {0}", list.Product());

            Console.WriteLine("Minimal element: {0}", list.Min());

            Console.WriteLine("Maximal element: {0}", list.Max());

            Console.WriteLine("Average sum of elements: {0}", list.Average());
        }
    }
}
