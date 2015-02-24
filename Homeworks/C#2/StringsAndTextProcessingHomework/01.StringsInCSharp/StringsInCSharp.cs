/*
Problem 1. Strings in C

Describe the strings in C#.
What is typical for the string data type?
Describe the most important methods of the String class.
*/



using System;
using System.Text;

namespace StringsInCSharpProblem
{
    class StringsInCSharp
    {
        static void Main()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(new string('-', Console.BufferWidth));
            text.AppendLine(@"A string is an object of type String whose value is text. Internally, 
the text is stored as a sequential read-only collection of Char objects. 
The Length property of a string represents the number of Char objects it contains, not the number of Unicode characters. 
To access the individual Unicode code points in a string, use the StringInfo object.");
            text.AppendLine(new string('-', Console.BufferWidth));
            text.AppendLine("Important C# string methods:");
            text.AppendLine("string.Compare(): Compares String objects.Has different overloads.");
            text.AppendLine("string.Equals(): Determines whether two specified String objects have the same value.");
            text.AppendLine("string.IndexOf(): Finding a character or substring within given string.");
            text.AppendLine("string.Substring(): Extract substring from the String object.");
            text.AppendLine("string.Split(): Splits string object by given separator.");
            text.AppendLine(new string('-', Console.BufferWidth));

            Console.WriteLine(text.ToString());
        }
    }
}
