/*
Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
*/ 


using System;
using System.Collections.Generic;

namespace ExtractEmailsProblem
{
    class ExtractEmails
    {
        static void Main()
        {
            string text = "Hello my name is Balkan, my email address is BalkanSuperman@yahoo.com and i can't get in to my account and i forgot my password?";
            
            string[] words = text.Split(' ', ',');
            List<string> mails = new List<string>();
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains("@"))
                {
                    if (words[i][words[i].Length - 1] == '.')
                    {
                        words[i] = words[i].Substring(0, words[i].Length - 1);
                    }

                    if (words[i].Contains("."))
                    {
                        if (words[i].IndexOf('@') < words[i].IndexOf('.'))
                        {
                            mails.Add(words[i]);
                        }
                    }
                }
            }

            foreach (var item in mails)
            {
                Console.WriteLine(item);
            }
        }
    }
}
