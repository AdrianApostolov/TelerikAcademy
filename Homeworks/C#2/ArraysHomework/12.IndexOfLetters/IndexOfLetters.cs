/*
 Problem 12. Index of letters

Write a program that creates an array containing all letters from the alphabet (A-Z).
Read a word from the console and print the index of each of its letters in the array.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)('A' + i);
        }

        Console.Write("Please, enter word: ");
        string word = Console.ReadLine().ToUpper();
        
        
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine("The index of '{0}' is {1}", word[i], j);
                }
            }
        }
    }
}

