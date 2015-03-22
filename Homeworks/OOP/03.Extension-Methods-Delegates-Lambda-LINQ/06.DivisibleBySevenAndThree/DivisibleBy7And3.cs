/*
Problem 6. Divisible by 7 and 3

Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
*/ 

namespace DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    class DivisibleBy7And3
    {
        static void Main()
        {
            int[] numbers = Enumerable.Range(1, 100).ToArray();

            var divisibleLambda = DivisibleBySevenAndThreeWithLambda(numbers);
            var divisibleLINQ = DivisibleBySevenAndThreeWithLINQ(numbers);

            Console.WriteLine("Numbers: {0}\n", string.Join(", ", numbers));
            Console.WriteLine("\nUsing extension methods: {0}\n", string.Join(", ", divisibleLambda));
            Console.WriteLine("\nUsing LINQ: {0}\n", string.Join(", ", divisibleLINQ));
        }

        public static int[] DivisibleBySevenAndThreeWithLambda(int[] numbers)
        {
            return numbers.Where(x => x % 21 == 0).ToArray();
        }

        public static int[] DivisibleBySevenAndThreeWithLINQ(int[] numbers)
        {
            var result = from number in numbers
                         where number % 21 == 0
                         select number;

            return result.ToArray();    
        }
    }
}
