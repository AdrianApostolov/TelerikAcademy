/*
Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.
Examples:

input	output
512	    two
1024	four
12309	nine
*/
using System;

class EnglishDigit
{                                                                               
    static string EnglishWord(int number)                                       
    {                                                                           
        int digit = number % 10;                                                
                                                                                
                                                                                
        switch (digit)                                                          
        {
            case 0: 
                Console.WriteLine("zero"); 
                break;
            case 1:
                Console.WriteLine("one");
                break;
            case 2:
                Console.WriteLine("two");
                break;
            case 3:
                Console.WriteLine("three");
                break;
            case 4:
                Console.WriteLine("four");
                break;
            case 5:
                Console.WriteLine("five");
                break;
            case 6:
                Console.WriteLine("six");
                break;
            case 7:
                Console.WriteLine("seven");
                break;
            case 8:
                Console.WriteLine("eight");
                break;
            case 9:
                Console.WriteLine("nine");
                break;
        }
        return "";
    }
        

    static void Main()
    {
        Console.Write("Please, enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Last digit of {0} as an english word is: ", number); 
        EnglishWord(number);
    }

}

