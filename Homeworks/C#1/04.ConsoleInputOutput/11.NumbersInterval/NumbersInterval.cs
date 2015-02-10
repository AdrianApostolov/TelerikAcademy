using System;

class NumbersInterval
{
    static void Main()
    {
        Console.Write("Please, enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Please, enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                Console.Write(i + ", ");
                count++;
            }

        }
        Console.WriteLine();
        Console.WriteLine("The members of the sequence is: " + count);
    }
}

