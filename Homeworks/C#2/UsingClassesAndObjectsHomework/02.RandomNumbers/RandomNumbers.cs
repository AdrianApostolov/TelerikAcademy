/*
Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
*/ 


using System;

namespace RandomNumbersProblem
{
    class RandomNumbers
    {
        static void Main()
        {
            Random rnd = new Random();
        
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Random number {0} = ", i + 1);
                int numbers = rnd.Next(100, 200);
                Console.WriteLine(numbers);
            }
        }
    }
}
