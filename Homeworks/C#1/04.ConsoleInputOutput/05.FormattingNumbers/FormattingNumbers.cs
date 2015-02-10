using System;

class FormattingNumbers
{
    static void Main()
    {
        here:
        Console.Write("Please, enter integer number A from 0 to 500: ");
        int a = int.Parse(Console.ReadLine());
        if ((a < 0) || (a > 500))
        {
            Console.WriteLine("Parameter is not in range [0 - 500]");
            goto here;
        }
        Console.Write("Please, enter floating-point number B: ");
        float b = float.Parse(Console.ReadLine());
        Console.Write("Please, enter floating-point number C: ");
        float c = float.Parse(Console.ReadLine());

        Console.WriteLine("{0, -10:X}|{1, -10}|{2, 10:F2}|{3, -10:F3}|",
                a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);
    }
}

