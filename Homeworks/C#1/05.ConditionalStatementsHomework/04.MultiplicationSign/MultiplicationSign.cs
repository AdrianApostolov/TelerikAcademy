using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Please, enter three numbers: ");
        Console.Write("Please, enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Please, enter second number: ");
        double secodNumber = double.Parse(Console.ReadLine());
        Console.Write("Please, enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber == 0 || secodNumber == 0 || thirdNumber == 0)
        {
            Console.WriteLine("Result: 0");
        }
        else if (firstNumber > 0 && secodNumber > 0 && thirdNumber > 0)
        {
            Console.WriteLine("Result: +");
        }
        else if (firstNumber < 0 && secodNumber < 0 && thirdNumber > 0)
        {
            Console.WriteLine("Result: +");
        }
        else if (firstNumber < 0 && secodNumber > 0 && thirdNumber < 0)
        {
            Console.WriteLine("Result: +");
        }
        else if (firstNumber > 0 && secodNumber < 0 && thirdNumber < 0)
        {
            Console.WriteLine("Result: +");
        }
        else
        {
            Console.WriteLine("Result: -");
        }
    }
}
