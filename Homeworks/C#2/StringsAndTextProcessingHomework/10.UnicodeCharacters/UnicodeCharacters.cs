/*
Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	     output
 Hi!  	\u0048\u0069\u0021
*/ 



using System;

namespace UnicodeCharactersProblem
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter some string: ");
            string input = Console.ReadLine();

            string result = string.Empty;

            Console.Write("Result after convert is: ");
            foreach (var character in input)
            {
               result = string.Format(@"\u{0:x4}", (int)character);
               Console.Write(result);
            }
            Console.WriteLine();
        }
    }
}
