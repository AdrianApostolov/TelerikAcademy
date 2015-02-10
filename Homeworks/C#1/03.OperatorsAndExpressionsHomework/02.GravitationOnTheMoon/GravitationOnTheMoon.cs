using System;

class GravitationOnTheMoon
{
    const double moonGravity = 0.17;
    static void Main()
    {
        Console.Write("Please, enter your weight: ");
        double weightEarth = double.Parse(Console.ReadLine());

        double weightMoon = weightEarth * moonGravity;
        Console.WriteLine("Your weight on the moon is: " + weightMoon +"kg");

    }
}

