using System;

class QuadraticEquation
{
    static void Main()
    {
         Console.Write("Please, enter intex a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, enter intex b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, enter intex c: ");
        double c = double.Parse(Console.ReadLine());

        double D = Math.Pow(b, 2) - 4 * a * c;
        if (D < 0)
        {
            Console.WriteLine("No real roots.");
        }
        else if (D == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("x1 = x2 = {0}", x);
        }
        else
        {
            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            Console.WriteLine("x1 = {0}\tx2 = {1}", x1, x2);
        }
    }
}

