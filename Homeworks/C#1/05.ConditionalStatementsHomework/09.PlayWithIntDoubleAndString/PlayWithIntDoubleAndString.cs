using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Please, choose type of varialbe:\n1 --> int\n2 --> double\n3 --> string");
        Console.Write("Please, enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1: Console.Write("Please enter a int: ");
                int integerInput = int.Parse(Console.ReadLine());
                Console.WriteLine(++integerInput);
                break;
            case 2: Console.Write("Please enter a double: ");
                double doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine(++doubleInput);
                break;
            case 3: Console.Write("Please enter a string: ");
                string stringInput = (Console.ReadLine());
                Console.WriteLine(stringInput + "*");
                break;
            default: Console.WriteLine("Invalid number");
                break;
        }
      
      

    }
}

