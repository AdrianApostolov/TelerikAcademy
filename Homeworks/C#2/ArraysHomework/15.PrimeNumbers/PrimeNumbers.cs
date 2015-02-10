/*
 Problem 15. Prime numbers

Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/


using System;
using System.Collections.Generic;
using System.Linq;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Please, enter number between 1 to 10 000 000: ");
        int number = int.Parse(Console.ReadLine());
        
        bool[] primeArray = new bool[number];
        
        for (int i = 0; i < primeArray.Length; i++)
        {
            primeArray[i] = true;
        }
        for (int i = 2; i < Math.Sqrt(primeArray.Length); i++)
        {
            for (int j = i * i; j < primeArray.Length; j += i)
            {
                primeArray[j] = false;
            }
        }

        for (int i = 0; i < primeArray.Length; i++)
        {
            if (primeArray[i])
            {
                Console.Write(i + ", ");
            }
        }
    }
}

