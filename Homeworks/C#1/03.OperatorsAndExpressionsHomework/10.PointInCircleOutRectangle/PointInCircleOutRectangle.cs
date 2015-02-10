using System;

class PointInCircleOutRectangle
{
    static void Main()
    {
        Console.Write("Please, enter value of X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please, enter value of Y: ");
        double y = double.Parse(Console.ReadLine());

        double radius = 1.5;

        bool isInCircle = (Math.Sqrt(((x - 1) * (x - 1)) + ((y - 1) * (y - 1))) <= radius);
        bool OutRectangel = ((x > -1 || x > 5) && (y > -1 || y > 1));

        bool inCircleOutRectangle = isInCircle && OutRectangel;

        Console.WriteLine("Inside K & outside of R ---> " + inCircleOutRectangle);

    }
}