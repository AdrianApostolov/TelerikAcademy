/*
Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
*/ 


using System;

namespace ParseTagsProblem
{
    class ParseTags
    {

        static string ParseTagsMethod(string text)
        {
            string result = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '<')
                {
                    i += 8;
                    while (text[i] != '<')
                    {
                        result += text[i].ToString().ToUpper();
                        i++;
                    }

                    i += 8;
                }
                else
                {
                    result += text[i];
                }
            }

            return result;
        }

        static void Main()
        {
            Console.WriteLine("Please, enter some text: ");
            string inputText = Console.ReadLine();

            Console.WriteLine(ParseTagsMethod(inputText));
        }
    }
}
