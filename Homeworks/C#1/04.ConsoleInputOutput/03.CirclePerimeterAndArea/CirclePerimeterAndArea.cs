using System;
 
class CirclePerimeterAndArea
{
    static void Main()
    {
        
        Console.Write("Please, enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        
        Console.WriteLine("The perimeter of the circle is: {0:0.00}, and the area is: {1:0.00} "
                                      ,(2 * Math.PI * radius),(Math.PI * radius * radius));
    }
}

