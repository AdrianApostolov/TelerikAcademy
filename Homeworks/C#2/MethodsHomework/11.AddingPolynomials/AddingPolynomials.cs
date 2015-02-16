/*
Problem 11. Adding polynomials

Write a method that adds two polynomials.
Represent them as arrays of their coefficients.
Example:

x2 + 5 = 1x^2 + 0x + 5 => {5, 0, 1}
*/


using System;
using System.Collections.Generic;
using System.Linq;

class AddingPolynomials
{
    static int[] EnterCoeficients(out int[] polynom)
    {
        Console.Write("Enter your polynomial degree: ");
        byte degree = byte.Parse(Console.ReadLine());
        polynom = new int[degree + 1];
        for (int i = polynom.Length - 1; i >= 0; i--)
        {
            Console.Write("x^" + i + ": ");
            polynom[i] = int.Parse(Console.ReadLine());
        }
        return polynom;
    }


    static int[] AddPolynomials(int[] firstArr, int[] secondArr, int[] result)
    {
       
        if (firstArr.Length > secondArr.Length)
        {
            return AddPolynomials(secondArr, firstArr, result);
        }
        
        int i = 0;
        for (; i < firstArr.Length; i++)
        {
            result[i] = firstArr[i] + secondArr[i];
        }

        for (; i < secondArr.Length; i++)
        {
            result[i] = secondArr[i];
        }

        return result;
    }


    static void PrintPolynomail(int[] print)
    {
        for (int i = print.Length - 1; i >= 0; i--)
        {
            if ((print[i] != 0) && (i != 0))
            {
                if (print[i - 1] >= 0)
                {
                    Console.Write(" {1}x^{0} +", i, print[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, print[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write(" {0}", print[i]);
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Please, enter coefficients for first polynomial.");
        int[] firstPolynomArray = EnterCoeficients(out firstPolynomArray);
        Console.Write("First polynomial in normal form:");
        PrintPolynomail(firstPolynomArray);

        Console.WriteLine(new string('=', 50));

        Console.WriteLine("Please, enter coefficients for second polynomial.");
        int[] secondPolynomArray = EnterCoeficients(out secondPolynomArray);
        Console.Write("Second polynomial in normal form: ");
        PrintPolynomail(secondPolynomArray);

        Console.WriteLine(new string('=', 50));

        Console.WriteLine("Adds two polynomials:");
        PrintPolynomail(firstPolynomArray);
        Console.WriteLine("+");
        PrintPolynomail(secondPolynomArray);
        Console.WriteLine("=");
       
        int[] result = new int[Math.Max(firstPolynomArray.Length, secondPolynomArray.Length)];
        PrintPolynomail(AddPolynomials(firstPolynomArray, secondPolynomArray, result));
    }
}
