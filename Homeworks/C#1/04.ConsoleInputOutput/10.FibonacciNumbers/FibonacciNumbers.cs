using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter the total number you want to display the series: ");
        string input = Console.ReadLine();
        int count = int.Parse(input);
        int firstNumber = 0;
        int secondNumber = 1;
        int sum;

        for (int i = 0; i < count; i++)
        {
            Console.Write("{0}, ", firstNumber);
            sum = firstNumber + secondNumber;
            firstNumber = secondNumber;
            secondNumber = sum;
        }
    }
}

