/*
 Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

    input	                            output
    .NET	            platform for applications from Microsoft
    CLR	                managed  execution environment for .NET
    namespace	        hierarchical organization of classes
*/ 


using System;
using System.Collections.Generic;

namespace WordDictionaryProblem
{
    class WordDictionary
    {
        static void Main()
        {
            Console.Write("Please, enter word: ");
            string inputWord = Console.ReadLine();
            bool wordExist = false;

            Dictionary<string, string> dictionary = new Dictionary<string, string>();

            dictionary.Add(".NET", "platform for applications from Microsoft");
            dictionary.Add("CLR", "managed  execution environment for .NET");
            dictionary.Add("namespace", "hierarchical organization of classes");

            foreach (var word in dictionary)
            {
                if (word.Key == inputWord)
                {
                    Console.WriteLine("{0} is {1}",inputWord, word.Value);
                    wordExist = true;
                }
            }
            if (wordExist != true)
            {
                Console.WriteLine("This word doesn`t exist in the dictionary.");
            }
           
            
        }
    }
}
