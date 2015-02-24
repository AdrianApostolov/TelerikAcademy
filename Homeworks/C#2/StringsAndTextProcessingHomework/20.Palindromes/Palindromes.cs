/*
Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
*/ 

using System;
using System.Collections.Generic;

namespace PalindromesProblem
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            string text = "The longest single English word in common usage which is a palindrome is redivider, although the contrived chemical term detartrated is two letters longer. In Finnish there is a 25-letter palindromic word: solutomaattimittaamotulos which means the result from a measurement laboratory for tomatoes, although technically it is a compound of four words. There is also the equally long saippuakuppinippukauppias which meanssoap cup trader.";

            string[] words = text.Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                bool isPalindrome = true;
                for (int j = 0; j < words[i].Length / 2; j++)
                {
                    if (words[i][j] != words[i][words[i].Length - 1 - j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome && words[i].Length > 1)
                {
                    palindromes.Add(words[i]);
                }
            }

            Console.WriteLine("The palindromes words is:");
            foreach (var word in palindromes)
            {
                Console.WriteLine(word);
            }
        }
    }
}
