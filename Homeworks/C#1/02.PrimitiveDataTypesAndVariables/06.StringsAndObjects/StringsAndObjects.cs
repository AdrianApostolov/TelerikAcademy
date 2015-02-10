using System;

class StringsAndObjects
{
    static void Main(string[] args)
    {
        string firstWord = "Hello";
        string secondWord = "World";
        object sentence = firstWord + ", " + secondWord;
        string newSentence = (string)sentence;
        Console.WriteLine(newSentence + "!");
    }
}

