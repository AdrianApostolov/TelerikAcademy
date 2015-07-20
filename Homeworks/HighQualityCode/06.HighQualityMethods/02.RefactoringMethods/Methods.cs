namespace RefactoringMethods
{
    using System;

    public class Methods
    {
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive.");

            }

            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                throw new ArgumentException("Invalid side sizes. Cannot be form triangle with the given sizes.");
            }

            double semiperimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));
            return area;
        }

        public static string GetDigitName(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid digit");
            }
        }

        public static int FindMaxNumber(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("There should be at least one argument.");
            }

            int maxNumber = int.MinValue;
            for (int i = 0; i < elements.Length; i++)
            {
                int currentNumber = elements[i];
                maxNumber = Math.Max(maxNumber, currentNumber);
            }

            return maxNumber;
        }

        public static void PrintAsPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        public static void PrintWithFixedPoint(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        public static void PrintWithRightAlignment(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        public static double CalcDistanceBetweenPoints(double firstPointX, double firstPointY, double secondPointX, double secondPointY)
        {
            double substractionProductX = (secondPointX - firstPointX) * (secondPointX - firstPointX);
            double substractionProductY = (secondPointY - firstPointY) * (secondPointY - firstPointY);

            double distance = Math.Sqrt(substractionProductX + substractionProductY);
            return distance;
        }

        public static bool AreTwoPointsHorizontal(double firstPointY, double secondPointY)
        {
            bool areTwoPointsHorizontal = firstPointY == secondPointY;
            return areTwoPointsHorizontal;
        }

        public static bool AreTwoPointsVertical(double firstPointX, double secondPointX)
        {
            bool areTwoPointsVertical = firstPointX == secondPointX;
            return areTwoPointsVertical;
        }

        public static void Main()
        {
            Console.WriteLine("The triangle are is: " + CalculateTriangleArea(3, 4, 5));

            int digit = 5;
            Console.WriteLine("Digit name of {0} is '{1}'", digit, GetDigitName(digit));

            Console.WriteLine("Max number of sequences is: " + FindMaxNumber(5, -1, 3, 2, 14, 2, 3));

            PrintAsPercent(1.3);
            PrintWithFixedPoint(0.75);
            PrintWithRightAlignment(2.30);

            double firstPointX = 3.0;
            double firstPointY = -1.0;
            double secondPointX = 3.0;
            double secondPointY = 2.5;
            double distance = CalcDistanceBetweenPoints(firstPointX, firstPointY, secondPointX, secondPointY);
            Console.WriteLine("Distance between two points: " + distance);
            Console.WriteLine("Are two points horizontal: " + AreTwoPointsHorizontal(firstPointY, secondPointY));
            Console.WriteLine("Are two points vertical: " + AreTwoPointsVertical(firstPointX, secondPointX));
        }
    }
}
