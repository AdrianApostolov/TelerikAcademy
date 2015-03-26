/*
Problem 3. Range Exceptions

Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. It should hold error message and a range definition [start … end].
Write a sample application that demonstrates the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] and dates in the range [1.1.1980 … 31.12.2013].
*/

namespace RangeExceptions
{
    using System;

    class RangeExceptionsMain
    {
        static void Main()
        {
            try
            {
                throw new InvalidRangeException<int>(5, 65);
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\n");

            try
            {
                throw new InvalidRangeException<DateTime>(new DateTime(1981, 1, 1), DateTime.Now);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
