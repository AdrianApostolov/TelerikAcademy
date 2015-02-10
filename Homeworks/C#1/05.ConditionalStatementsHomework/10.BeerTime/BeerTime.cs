using System;
using System.Globalization;

class BeerTime
{
    static void Main()
    {
        Console.Write("Please, enter a time in format “hh:mm tt” (e.g. 01:42 AM/PM): ");
        string input = Console.ReadLine();
        DateTime startTimeForBeer = DateTime.Parse("1:00 PM");
        DateTime endTimeForBeer = DateTime.Parse("3:00 AM");

        try
        {
            DateTime beerTime = DateTime.ParseExact(input, "h:mm tt", CultureInfo.InvariantCulture);

            if (beerTime >= startTimeForBeer || beerTime < endTimeForBeer)
            {
                Console.WriteLine("It's beer time!");
            }
            else
            {
                Console.WriteLine("Non-beer time!");
            }
        }
        catch
        {
            Console.WriteLine("Invalid time!");
        }
    }
}

