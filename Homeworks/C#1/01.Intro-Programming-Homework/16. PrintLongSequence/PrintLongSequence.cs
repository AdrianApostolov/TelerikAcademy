using System;


class PrintLongSequence
{
    static void Main()
    {   
        for (int i = 2; i <= 1001;)
        {
            Console.Write(i++);
            Console.Write(-i++);
        }
    
    }
}

