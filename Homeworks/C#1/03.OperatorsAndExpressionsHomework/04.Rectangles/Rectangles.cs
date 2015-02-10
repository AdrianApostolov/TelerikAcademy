using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Please, enter width of the rectangle: ");
        double wedth = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Please, enter height of the rectangle: ");
        double heidht = double.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Please, enter measurement unit: ");
        string measurementUnit = Console.ReadLine();
        Console.Clear();
        
        double perimeter = 2 * wedth + 2 * heidht;
        double area = wedth * heidht;
        
        Console.WriteLine("The rectangle`s perimeter: "+ perimeter + measurementUnit);
        Console.WriteLine("The rectangle`s area: "+ area + measurementUnit + "2");
    }
}
