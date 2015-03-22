/*
Problem 1. StringBuilder.Substring

Implement an extension method Substring(int index, int length) for the class StringBuilder 
that returns new StringBuilder and has the same functionality as Substring in the class String.
*/


namespace StringBuilderSubstringProblem
{
    using System;
    using System.Text;

    class StringBuilderSubstringMain
    {
        public static void Main()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Implement an extension method Substring");
            Console.WriteLine(sb);

            sb.Substring(13);
            Console.WriteLine(sb);

            sb.Substring(10, 6);
            Console.WriteLine(sb);
        }
    }
}
