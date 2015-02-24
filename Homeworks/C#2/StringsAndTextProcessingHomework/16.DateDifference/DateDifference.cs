/*
Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
*/


using System;
using System.Globalization;

namespace DateDifferenceProblem
{
    class DateDifference
    {
        static void Main()
        {
            Console.Write("Enter the first date in the format [dd.MM.yyyy]: ");
            string firstDate = Console.ReadLine();
            Console.Write("Enter the second date in the format [dd.MM.yyyy]: ");
            string secondDate = Console.ReadLine();

            DateTime dateFirst = DateTime.ParseExact(firstDate, "d.M.yyyy", CultureInfo.InvariantCulture);
            DateTime dateSecond = DateTime.ParseExact(secondDate, "d.M.yyyy", CultureInfo.InvariantCulture);

            var distance = Math.Abs((dateSecond - dateFirst).TotalDays);

            Console.WriteLine("Distance between {0} and {1} = {2} days\n", firstDate, secondDate, distance);

        }
    }
}
