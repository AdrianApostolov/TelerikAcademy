/*
Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
*/ 


using System;
using System.Numerics;

class NFactorial
{
    static BigInteger Factorial(int i)
    {
        BigInteger facturial = i;
        while (i > 1)
        {
            facturial *= i - 1;
            i--;
        }
        return facturial;
    }


    static BigInteger ArrayMultiply(int number)
    {
        BigInteger nFacturial = 1;
        int [] array = new int[number];
        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        
        for (int i = 0; i <array.Length; i++)
			{
                nFacturial = Factorial(array[i]); 
			}
        return nFacturial;
    }

    static void Main()
    {
        Console.Write("Please, enter integer number: ");
        int input = int.Parse(Console.ReadLine());

        Console.WriteLine("{0}! = " + ArrayMultiply(input), input);
    }
}

