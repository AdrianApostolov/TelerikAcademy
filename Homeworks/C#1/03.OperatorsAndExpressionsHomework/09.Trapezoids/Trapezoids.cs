using System;

class Trapezoids
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter side a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please, enter side b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please, enter height h: ");
        double h = double.Parse(Console.ReadLine());
        Console.Write("Please, enter metric prefix: ");
        string metricPrefix = Console.ReadLine();

        double area = ((a + b) / 2) * h;
        Console.WriteLine("The trapezoid's area is: " + area + metricPrefix + 2);

    }
}

