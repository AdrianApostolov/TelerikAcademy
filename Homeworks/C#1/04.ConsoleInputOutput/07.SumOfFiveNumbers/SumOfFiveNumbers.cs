using System;

class SumOfFiveNumbers
{
    static void Main()
    {
        Console.Write("Enter five numbers separated by space: ");

        string[] userInput = Console.ReadLine().Split();
        double a = Convert.ToDouble(userInput[0]);
        double b = Convert.ToDouble(userInput[1]);
        double c = Convert.ToDouble(userInput[2]);
        double d = Convert.ToDouble(userInput[3]);
        double e = Convert.ToDouble(userInput[4]);

        double sumOfAll = a + b + c + d + e;
        Console.WriteLine("The sum of the numbers is: {0} ", sumOfAll);
    }
}

