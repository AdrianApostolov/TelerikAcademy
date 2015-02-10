using System;

class PointInACircle
{
    static void Main(string[] args)
    {
        
        Console.Write("Please, enter coordinate X: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Please, enter coordinate Y: ");
        double y = double.Parse(Console.ReadLine());

        double point = Math.Sqrt((x * x) + (y * y));

        if (point <= 2) 
        
        {
            Console.WriteLine("The point is inside a circle: " + true);

        }
        else 
            Console.WriteLine("The point is not inside a circle: " + false);


    }
}