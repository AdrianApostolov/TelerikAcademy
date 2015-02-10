using System;

class ModifyBitGivenPosition
{
    static void Main()
    {
        Console.Write("Please, enter integer number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("The binary representation of {0} is:\n{1} "
            , number, Convert.ToString(number, 2).PadLeft(16, '0'));

        Console.Write("Please, enter number of bit position: ");
        int bitPosition = int.Parse(Console.ReadLine());

        Console.Write("Please, enter value of the bit: ");
        int valueOfBit = int.Parse(Console.ReadLine());

        int mask = 1 << bitPosition;
        
       
        if (valueOfBit == 0)
          {
              number = number & (~mask);
              Console.WriteLine("Binary result is:\n{0} and now has value of: {1}",
                  Convert.ToString(number, 2).PadLeft(16, '0'), number);

          }
        else // (valueOfbit == 1)
        {
            number = number | mask;
            Console.WriteLine("Binary result is:\n{0} and now has value of: {1}",
                Convert.ToString(number, 2).PadLeft(16, '0'), number);
        }

          

    }
}

