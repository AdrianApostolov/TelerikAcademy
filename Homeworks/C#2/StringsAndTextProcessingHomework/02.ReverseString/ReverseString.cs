/*
 Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas
*/ 


using System;

namespace ReverseStringProblem
{
    class ReverseString
    {
        public static string ReverseWhitLoop(string text)
        {
            char[] charArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = charArray.Length - 1; i > -1; i--)
            {
                reverse += charArray[i];
            }
            return reverse;
        }

        public static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main()
        {
            Console.Write("Please, enter some string: ");
            string input = Console.ReadLine();

            Console.WriteLine("Reversed string with loop is: " + ReverseWhitLoop(input));

            Console.WriteLine("Reversed string is: " + Reverse(input));
        }
    }
}
