/*
Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is in

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
*/ 


using System;

namespace SubstringInTextProblem
{
    class SubstringInText
    {
        static int SubstringSearch(string text, string substring)
        {
            int count = 0;

            for (int i = 0; i < text.Length - substring.Length; i++)
			{

                if (text.Substring(i, substring.Length).ToLower() == substring)
                {
                    count++;
                    i += substring.Length;
                }
            }

            return count;
        }

        static void Main()
        {
            Console.WriteLine("Please, enter some text: ");
            string inputText = Console.ReadLine();

            Console.WriteLine("Please, enter the target sub-string: ");
            string target = Console.ReadLine().ToLower();

            int result = SubstringSearch(inputText, target);
            Console.WriteLine("A sub-string is contained in a given text {0} time(s)", result);
        }
    }
}
