using System;

class PrintSequence
{
    static void Main()
    {
        for (int i = 2; i <= 11; )
        {
            Console.WriteLine(i++);
            Console.WriteLine(-i++);
        }
    }
}