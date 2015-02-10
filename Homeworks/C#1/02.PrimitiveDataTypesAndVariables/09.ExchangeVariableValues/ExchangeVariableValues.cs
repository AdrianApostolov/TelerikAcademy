using System;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Variable values:");
        Console.WriteLine("{0} \n{1}", a, b);

        Console.WriteLine("===============================");

        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("Variable values after exchange:");
        Console.WriteLine("{0} \n{1}", a, b);
    }
}

