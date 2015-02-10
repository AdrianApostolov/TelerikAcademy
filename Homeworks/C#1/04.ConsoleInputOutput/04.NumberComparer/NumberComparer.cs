using System;

class Program
{
    static void Main()
    {
        Console.Write("Please, enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("The greater number is: {0} ", Math.Max(firstNumber, secondNumber));
    }
}

