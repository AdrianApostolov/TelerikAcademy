using System;

class ExtractThirdBit
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter unsigned integer: ");
        int number = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("The binary representation of the {0} is:\n{1}"
                            , number, Convert.ToString(number, 2).PadLeft(16, '0'));
        int p = 3;
        int mask = 1 << p;
        int numberAndMask = number & mask;
        int bitResult = numberAndMask >> p;

            Console.WriteLine("The third bit is:" + bitResult);
    }
}
