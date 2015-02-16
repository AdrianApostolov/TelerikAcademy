/*
Problem 13. Solve tasks

* Write a program that can solve these tasks:
    -Reverses the digits of a number
    -Calculates the average of a sequence of integers
    -Solves a linear equation a * x + b = 0
*Create appropriate methods.
*Provide a simple text-based menu for the user to choose which task to solve.
*Validate the input data:
    -The decimal number should be non-negative
    -The sequence should not be empty
    -a should not be equal to 0
*/ 


using System;

class SolveTasks
{
    static void ReverseDigits()
    {
        while (true)
        {

            Console.Write("Enter decimal value: ");
            decimal decimalNumber = decimal.Parse(Console.ReadLine());
           
            if (decimalNumber > 0)
            {
                char[] temp = decimalNumber.ToString().ToCharArray();

                char[] reversed = new char[temp.Length];

                for (int index = 0; index < temp.Length; index++)
                {
                    reversed[temp.Length - index - 1] = temp[index];
                }
                Console.Write("Reversed: ");
                foreach (var number in reversed)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
            }
        }
    }

    static void AvarageOfSequence()
    {
        while (true)
        {
            Console.Write("Enter a positive number for arrays lenght ");
            int inputNumber = Int32.Parse(Console.ReadLine());
            if (inputNumber > 0)
            {
                int sum = 0;
                double avarage;
                int[] arrayNumber = new int[inputNumber];
                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    Console.Write("Enter, element[{0}] = ", i);
                    arrayNumber[i] = Int32.Parse(Console.ReadLine());
                }
                for (int i = 0; i < arrayNumber.Length; i++)
                {
                    sum += arrayNumber[i];
                }
                avarage = (double)sum / inputNumber;
                Console.WriteLine("The average from the sequence is {0}", avarage);
                break;
            }
        }
    }

    static void SolveLinearEquation()
    {
        Console.Write("Enter value for coefficients \"a\":");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine();

        if (a != 0)
        {
            Console.Write("Enter value for coefficients \"b\":");
            double b = double.Parse(Console.ReadLine());
            double x = -b / a;
            Console.WriteLine("x = {0}", x);
        }
        else
        {
            Console.WriteLine("Enter value different from 0");
            SolveLinearEquation();
        }
    }

    static void Main()
    {
        string input = "0";
        while (input == "0")
        {
            Console.WriteLine("MENU".PadLeft(20));
            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Choose which task to solve: ");
            Console.WriteLine("1 - Reverses the digits of a number");
            Console.WriteLine("2 - Calculates the average of a sequence of integers");
            Console.WriteLine("3 - Solves a linear equation 'a * x + b = 0'");
            Console.WriteLine(new string('=', 40));
            Console.Write("Enter your choice: ");
            input = Console.ReadLine();
            switch (input)
            {
                case "1": ReverseDigits();
                    return;
                case "2": AvarageOfSequence();
                    return;
                case "3": SolveLinearEquation();
                    return;
                default:
                    Console.Clear();
                    input = "0";
                    break;
            }
        }
    }
}
