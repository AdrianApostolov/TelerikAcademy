using System;
using System.Text;


class PrintASCII
{
    static void Main()
    {
        for (int i = 1; i < 256; i++)
        {
            Console.WriteLine("{0} = {1}", i, (char)i);
        }
    }
}

