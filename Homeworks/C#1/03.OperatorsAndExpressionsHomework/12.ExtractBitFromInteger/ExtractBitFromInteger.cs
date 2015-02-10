using System;

class ExtractBitFromInteger
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("The binary representation of the {0} is:\n{1}"
                            , number, Convert.ToString(number, 2).PadLeft(16, '0'));
        
        Console.Write("Please, enter number of the bit: ");
        int index = int.Parse(Console.ReadLine());
        
        int mask = 1 << index;
        int intexAndMask = number & mask;
        int result = intexAndMask >> index;

        Console.WriteLine("The position of the enter number of bit is: " + result);
    }
}
