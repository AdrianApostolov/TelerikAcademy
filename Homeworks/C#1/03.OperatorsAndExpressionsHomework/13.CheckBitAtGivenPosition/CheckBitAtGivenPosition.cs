using System;

class CheckBitAtGivenPosition
{
    static void Main(string[] args)
    {
        Console.Write("Please, enter integer number: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.Write("The binary representation of {0} is:\n{1} "
            ,number, Convert.ToString(number, 2).PadLeft(16, '0'));
       
        Console.Write("Please, enter number of bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        int mask = 1 << bitPosition;
        int bitPositionAndMask = number & mask;
        int result = bitPositionAndMask >> bitPosition;
 
        bool bitHasValue1 = (result == 1) ? true : false;
        Console.WriteLine(bitHasValue1);



    }
}

