/*
Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/


using System;
using System.Globalization;
using System.Text;

namespace DateInBulgarianProblem
{
    class DateInBulgarian
    {
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
            Console.OutputEncoding = Encoding.Unicode;

            Console.Write("Enter the date and time in the format [dd.MM.yyyy hh:mm:ss]: ");
            string input = Console.ReadLine();

            //28.02.2015 10:10:00
            DateTime date = DateTime.ParseExact(input, "d.M.yyyy h:m:s", CultureInfo.GetCultureInfo(("bg-BG")));
            date = date.AddHours(6.5);

            Console.WriteLine(date.ToString("dd.MM.yyyy HH:mm:ss dddd"),CultureInfo.GetCultureInfo(("bg-BG")));
            
        }
    }
}
