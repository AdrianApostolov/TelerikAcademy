using System;


class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Please, enter numer A: ");
        double firstNumber = double.Parse(Console.ReadLine());
        
        Console.Write("Please, enter numer B: ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter numer C: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the entered three number is: {0} " ,(firstNumber + secondNumber + thirdNumber));
    }
}

