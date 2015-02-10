using System;

class BitsExchange
{
    static void Main()
    {
        Console.WriteLine("Enter Unsigned Integer number:");
        uint number = uint.Parse(Console.ReadLine());

        Console.WriteLine("The binary represantation of {0} is: \n{1}",
                             number,
                             Convert.ToString(number, 2).PadLeft(32, '0'));

        uint maskFirst = 56u;      
        uint maskLast = 117440512u; 
       
        uint first3Bits = number & maskFirst;
        uint last3Bits = number & maskLast;
       
        first3Bits = first3Bits << 21;
        last3Bits = last3Bits >> 21;
     
        number = number & (~maskFirst);
        number = number & (~maskLast);
       
        number = number | first3Bits;
        number = number | last3Bits;

        Console.WriteLine("Binary result is:\n{0}\nResult: {1}"
                            , Convert.ToString(number, 2).PadLeft(32, '0')
                            , number);
    }
}
