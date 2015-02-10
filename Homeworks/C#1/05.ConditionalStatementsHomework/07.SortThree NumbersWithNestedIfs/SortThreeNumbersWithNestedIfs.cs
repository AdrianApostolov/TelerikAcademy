using System;

class SortThreeNumbersWithNestedIfs
{
    static void Main()
    {
        Console.WriteLine("Please, enter three numbers: ");

        Console.Write("Please, enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter second number: ");
        double secodNumber = double.Parse(Console.ReadLine());

        Console.Write("Please, enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secodNumber && firstNumber > secodNumber)
        {
            if (secodNumber > thirdNumber)
            {
                Console.WriteLine("Sort Numbers: {0} {1} {2}",firstNumber,secodNumber,firstNumber);
            }
            else
            {
                Console.WriteLine("Sort Numbers: {0} {2} {1}", firstNumber, secodNumber, thirdNumber);
            }
        }
        else if (secodNumber > firstNumber && secodNumber > thirdNumber)
        {
            if (firstNumber > thirdNumber)
            {
                Console.WriteLine("Sort Numbers: {1} {0} {2}", firstNumber, secodNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("Sort Numbers: {1} {2} {0}", firstNumber, secodNumber, thirdNumber);
            }
        }
        else
        {
            if (firstNumber > secodNumber)
            {
                Console.WriteLine("Sort Numbers: {2} {0} {1}", firstNumber, secodNumber, thirdNumber);
            }
            else
            {
                Console.WriteLine("Sort Numbers: {2} {1} {0}", firstNumber, secodNumber, thirdNumber);
            }
        }
    }
}
