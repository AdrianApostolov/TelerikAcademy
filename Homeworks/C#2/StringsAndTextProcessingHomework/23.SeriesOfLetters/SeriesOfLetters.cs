/*
Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

          input	              output
aaaaabbbbbcdddeeeedssaa	     abcdedsa
*/ 


using System;
using System.Text;

namespace SeriesOfLettersProblem
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string text = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder letters = new StringBuilder();
            letters.Append(text);
            for (int i = 0; i < letters.Length; i++)
            {
                char letter = letters[i];
                for (int j = i + 1; j < letters.Length; j++)
                {
                    if (letters[j] == letter)
                    {
                        letters.Remove(j, 1);
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(letters);
        }
    }
}
