/*
Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
*/


using System;

namespace WordsCountProblem
{
    class WordsCount
    {
        static void Main()
        {
            Console.WriteLine("Please, enter some text: ");
            string text = Console.ReadLine();

            text = text.ToLower();
            string[] words = text.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
           
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == string.Empty) continue;

                int wordCounter = 1;
                if (i < words.Length - 1)
                {
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            wordCounter++;
                            words[j] = string.Empty;
                        }
                    }
                }

                Console.WriteLine("{0,-10} -> {1,2} times", words[i], wordCounter);
            }
        }
    }
}
