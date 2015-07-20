namespace Abstraction
{
    using System;

    public class FiguresExample
    {
        public static void Main()
        {
            Circle circle = new Circle(5);
            Console.WriteLine(circle + Environment.NewLine);
            
            Rectangle rectangle = new Rectangle(2, 3);
            Console.WriteLine(rectangle);
        }
    }
}
