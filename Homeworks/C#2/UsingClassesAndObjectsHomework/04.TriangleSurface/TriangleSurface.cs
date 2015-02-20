/*
Problem 4. Triangle surface

Write methods that calculate the surface of a triangle by given:
Side and an altitude to it;
Three sides;
Two sides and an angle between them;
Use System.Math.
*/ 


using System;

namespace TriangleSurfaceProblem
{
    class TriangleSurface
    {
        static double CalculateAreaWhitSideAndAltitude(double side, double altitude)
        {
            return (side * altitude) / 2;
        }


        static double CalculateAreaWhitThreeSides(double firstSide, double secondSide, double thirdSide)
        {
            double p = (firstSide + secondSide + thirdSide) / 2;

            return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
        }

        static double CalculateAreaWhitTwoSidesAndAngle(double firstSide, double secondSide, double angel)
        { 
            double test = Math.Sin(Math.PI - angel);
            return  (firstSide * secondSide * test ) / 2;
            //return (firstSide * secondSide * Math.Sin(Math.PI * angel / 180)) / 2;
        }
        
        static void Main()
        {
            Console.WriteLine("Calculet triangle surface".PadLeft(40));
            Console.WriteLine("********************MENU********************");
            Console.WriteLine("1.Calculate by given side and an altitude to it");
            Console.WriteLine("2.Calculate by given three sides");
            Console.WriteLine("3.Calculate by given two sides and an angle between them");
            Console.WriteLine("********************************************");
            Console.Write("Choice method to calculate the surface of a triangle");
            int choice = 0;
            do
            {
                Console.Write("Your choice: ");
                choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Please, enter size of side: ");
                        int inputSide = int.Parse(Console.ReadLine());
                        Console.Write("Please, enter size of altitude: ");
                        int inputAltitude = int.Parse(Console.ReadLine());
                        Console.WriteLine("The surface of the triangle is: "
                            + CalculateAreaWhitSideAndAltitude(inputSide, inputAltitude)); break;
                    
                    case 2: 
                        Console.Write("Please enter size of first side: ");
                        double firstInputSide = double.Parse(Console.ReadLine());
                        Console.Write("Please enter size of second side: ");
                        double secondInputSide = double.Parse(Console.ReadLine());
                        Console.Write("Please enter size of third side: ");
                        double thirdInputSide = double.Parse(Console.ReadLine());
                        Console.WriteLine("The surface of the triangle is: "
                            + CalculateAreaWhitThreeSides(firstInputSide, secondInputSide, firstInputSide));break;
                    
                    case 3: 
                        Console.Write("Please enter size of first side: ");
                        double firstSideInput = double.Parse(Console.ReadLine());
                        Console.Write("Please enter size of second side: ");
                        double secondSideInput = double.Parse(Console.ReadLine());
                        Console.Write("Please enter size of third side: ");
                        Console.Write("Please, enter size of angle: ");
                        double angleInput = double.Parse(Console.ReadLine());
                        Console.WriteLine("The surface of the triangle is: " 
                            + CalculateAreaWhitTwoSidesAndAngle(firstSideInput, secondSideInput, angleInput));break;
                    default: Console.WriteLine("Wrong choice");
                        break;
                }

            } while (choice < 0 || choice > 3);
                



        }
    }
}
