using System;

class TheBiggestOfFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers: ");
        double[] numbers = new double[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }
        
        double biggestNumber = numbers[0];
        
        if (biggestNumber <= numbers[1])
        {
            biggestNumber = numbers[1];
        }
        if (biggestNumber <= numbers[2])
        {
            biggestNumber = numbers[2];
        }
        if (biggestNumber <= numbers[3])
        {
            biggestNumber = numbers[3];
        }
        if (biggestNumber <= numbers[4])
        {
            biggestNumber = numbers[4];
        }

        Console.WriteLine("The biggest number is: " + biggestNumber);

    }
}
