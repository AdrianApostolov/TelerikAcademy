/*
Problem 17. Longest string

Write a program to return the string with maximum length from an array of strings.
Use LINQ.
*/


namespace LongestString
{
    using System;
    using System.Linq;

    class LongestStringProgram
    {
        static void Main()
        {
            string[] someStrings = new string[] 
            {
                "string",
                "longestString",
                "someString",
                "anotheString"
            };

            string longest = LongestString(someStrings);

            Console.WriteLine("Strings in array: {0}\n", string.Join(", ", someStrings));
            Console.WriteLine("The longest string: {0}\n", longest);
        }

        public static string LongestString(string[] array)
        {
            var longestString = (from strings in array
                                 orderby strings.Length descending
                                 select strings).First();

            return longestString.ToString();
        }
    }
}
