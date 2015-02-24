/*
Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
*/ 


using System;

namespace CorrectBracketsProblem
{
    class CorrectBrackets
    {
        static bool AreBracketsCorrect(string expression)
        {
            int bracketsCounter = 0;
            foreach (var element in expression)
            {
                if (element == '(')
                {
                    bracketsCounter++;
                }
                else if (element == ')')
                {
                    bracketsCounter--;
                }

                if (bracketsCounter < 0)
                {
                    return false;
                }
            }

            return bracketsCounter == 0;
        }

        static void Main()
        {
            Console.Write("Please enter an expression: ");
            string input = Console.ReadLine();

            if (AreBracketsCorrect(input) == true)
            {
                Console.WriteLine("The brackets in expression are put correctly");
            }
            else
            {
                Console.WriteLine("The brackets in your expression are put incorrectly");
            }
        }
    }
}
