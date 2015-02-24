/*
Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
*/ 


using System;

namespace OrderWordsProblem
{
    class OrderWords
    {
        static void Main()
        {
            Console.WriteLine("Enter words, separated by a spaces: ");
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            Array.Sort(words);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine();

            // With selection sort
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = i + 1; j < words.Length; j++)
                {
                    if (words[i].CompareTo(words[j]) > 0)
                    {
                        string temp = words[i];
                        words[i] = words[j];
                        words[j] = temp;
                    }
                }
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
        }
    }
}
