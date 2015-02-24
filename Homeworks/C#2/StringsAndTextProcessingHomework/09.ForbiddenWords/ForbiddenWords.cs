/*
Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.
Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: ********* announced its next generation *** compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
*/


using System;
using System.Linq;



namespace ForbiddenWordsProblem
{
    class ForbiddenWords
    {
        static void Main()
        {
            Console.Write("Please, enter forbidden words separated by a space: ");
            
            string[] forbiddenWords = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            Console.WriteLine("Please, enter some text: ");
            string text = Console.ReadLine();

            for (int i = 0; i < forbiddenWords.Length; i++)
			{
                if (text.Contains(forbiddenWords[i]))
                {
                    text = text.Replace(forbiddenWords[i], new string('*', forbiddenWords[i].Length));
                }
			}
            Console.Clear();
            Console.WriteLine("The censored text is: \n{0}", text);
        }
    }
}
