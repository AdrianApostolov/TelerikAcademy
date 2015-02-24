/*
Problem 6. String length

Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
Print the result string into the console.
*/ 


using System;
using System.Text;

namespace StringLengthProblem
{
    class StringLength
    {
        static void Main()
        {
            Console.Write("Please, enter some string: ");
            string inputString = Console.ReadLine();
            string fillePart = string.Empty;

            if (inputString.Length <= 20)
            {
                Console.WriteLine(inputString);
            }
            else
            {


                fillePart = inputString.Substring(20, inputString.Length - 20);

                for (int i = 0; i < fillePart.Length; i++)
                {
                    fillePart = fillePart.Replace(fillePart[i], '*');
                }


                string charactersPart = inputString.Substring(0, 20);

                StringBuilder result = new StringBuilder();

                result.Append(charactersPart);
                result.Append(fillePart);

                Console.WriteLine("Result is:");
                Console.WriteLine(result);
            }
               
        }
    }
}
