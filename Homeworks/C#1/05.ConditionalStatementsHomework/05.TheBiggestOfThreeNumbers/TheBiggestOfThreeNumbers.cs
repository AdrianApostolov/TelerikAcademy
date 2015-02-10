using System;

class TheBiggestOfThreeNumbers
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

        
        if (firstNumber > secodNumber && firstNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is: " + firstNumber);
        }
        else if (secodNumber < firstNumber && secodNumber > thirdNumber)
        {
            Console.WriteLine("The biggest number is: " + secodNumber);
        }
        else if (thirdNumber > firstNumber && thirdNumber > secodNumber)
        {
            Console.WriteLine("The biggest number is: " + thirdNumber);
        }
        
    }
}

