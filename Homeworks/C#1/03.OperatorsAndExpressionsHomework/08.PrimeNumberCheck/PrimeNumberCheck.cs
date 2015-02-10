using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Please, enter positive integer number n (n <= 100): ");
        int number = int.Parse(Console.ReadLine());
        if (number > 100)
        {
            Console.WriteLine("Error, please enter number >= 100");
        }
        else
            if (number == 0 || number == 1)
            {
                Console.WriteLine(number + " is not prime number");
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= number / 2; a++)
                {
                    if (number % a == 0)
                    {
                        Console.WriteLine(number + " is not prime number");
                        return;
                    }

                }
                Console.WriteLine(number + " is a prime number");
                Console.ReadLine();
            }
    }

}
