/*
Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/ 


using System;
using System.Linq;

namespace WorkdaysProblem
{
    class Workdays
    {
        static readonly DateTime[] holidays = 
        {
            new DateTime(2015, 1, 1),
            new DateTime(2015, 3, 1),
            new DateTime(2015, 4, 10),
            new DateTime(2015, 4, 13),
            new DateTime(2015, 5, 1),
            new DateTime(2015, 5, 6),
            new DateTime(2015, 5, 24),
            new DateTime(2015, 9, 6),
            new DateTime(2015, 9, 22),
            new DateTime(2015, 12, 24),
            new DateTime(2015, 12, 25),
        };
        private static int CheckWorkDays(DateTime dateNow, DateTime futureDate)
        {
            int count = 0;
            if (dateNow > futureDate)
            {
                DateTime swap = dateNow;
                dateNow = futureDate;
                futureDate = swap;
            }
            while (dateNow <= futureDate)
            {
                if (!holidays.Contains(dateNow) && dateNow.DayOfWeek != DayOfWeek.Saturday && dateNow.DayOfWeek != DayOfWeek.Sunday)
                {
                    count++;
                }
                dateNow = dateNow.AddDays(1);
            }
            return count;
        }

        static void Main()
        {
            DateTime dateNow = DateTime.Now;
            Console.WriteLine("Enter a date in the future between today and 31.12.2015 in format dd.MM.yyyy:");
            int[] endDateInput = Console.ReadLine().Split('.').Select(int.Parse).ToArray();
            DateTime endDate = new DateTime(endDateInput[2], endDateInput[1], endDateInput[0]);

            Console.WriteLine("\nTotal workdays: {0}", CheckWorkDays(dateNow, endDate)); 
        }
    }
}
