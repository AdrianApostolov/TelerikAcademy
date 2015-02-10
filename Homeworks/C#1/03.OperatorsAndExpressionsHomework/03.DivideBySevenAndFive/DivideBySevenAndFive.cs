using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Please, enter numerb: ");
        int number = int.Parse(Console.ReadLine());
        
        if (number % 5  == 0)
        if (number % 7  == 0)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}

