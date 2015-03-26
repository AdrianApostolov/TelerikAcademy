/*
Problem 1. Shapes

Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure (heightwidth for rectangle and heightwidth/2 for triangle).
Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
Write a program that tests the behaviour of the CalculateSurface() method for different shapes (Square, Rectangle, Triangle) stored in an array.
*/

namespace Shapes
{
    using System;

    public class ShapesMain
    {
        public static void Main()
        {
            double width = 3;
            double height = 4;

            var shapes = new Shape[] 
            {
                new Rectangle(width, height),
                new Triangle(width, height),
                new Square(width, height)
            };

            Console.WriteLine("Width: {0}, Height: {1}", width, height);

            foreach (var shape in shapes)
            {
                Console.WriteLine("Shape: {0} with surface: {1}", shape.GetType().Name, shape.CalculateSurface());
            }
        }
    }
}
