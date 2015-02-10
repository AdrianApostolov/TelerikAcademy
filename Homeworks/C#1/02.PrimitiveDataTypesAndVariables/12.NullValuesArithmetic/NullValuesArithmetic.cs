using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstVariable = null;
        double? secodVariable = null;
        Console.WriteLine("Here is result of int null value: "+ firstVariable);
        Console.WriteLine("Here is result of double null value: "+ secodVariable);

        string separator = new String('_', 40);
        Console.WriteLine(separator);

        firstVariable = 12;
        secodVariable = 23;
        Console.WriteLine("Here is result of int with a value: "+ firstVariable);
        Console.WriteLine("Here is result of double with a value: "+ secodVariable);
    }
}

