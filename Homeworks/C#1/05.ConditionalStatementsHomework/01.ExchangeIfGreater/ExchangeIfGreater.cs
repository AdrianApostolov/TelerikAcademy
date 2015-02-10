using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Please, enter two numbers!");
        Console.Write("Please, enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please, enter seconsd number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            Console.WriteLine("Result is: {0} {1}",secondNumber, firstNumber);
        }
        else
        {
            Console.WriteLine("Result is: {0} {1}",firstNumber, secondNumber);
        }
    }
}
