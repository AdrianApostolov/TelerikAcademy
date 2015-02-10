using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please, enter four digit numer without leading zeros: ");
        int number = int.Parse(Console.ReadLine());
        
        while (number < 1000 || number > 9999)
        {
            Console.Write("Erorr! Enter four digit number: ");
            number = int.Parse(Console.ReadLine());
        }
       
        int d = number % 10;
        number /= 10;
        int c = number % 10;
        number /= 10;
        int b = number % 10;
        number /= 10;
        int a = number % 10;

        int sum = a + b + c + d;
        Console.WriteLine("The sum of the digits is: " + sum);
        Console.WriteLine("The number in reversed order is: "+ d + c + b + a);
        Console.WriteLine("The number wiht puts last digit in the first position is : "+ d + a + b + c);
        Console.WriteLine("The number whit exchanges the second and the third digits: " + a + c + b + d);

          

    }
}


