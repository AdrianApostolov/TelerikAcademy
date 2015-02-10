using System;

class BankAccountData
{
    static void Main()
    {
        Console.Write("Hello, please enter your Full name: ");
        string fullName = Console.ReadLine();
        Console.Clear();
        
        Console.Write("Please enter your available amount of money(balance): ");
        int balance = int.Parse(Console.ReadLine());
        Console.Clear();
       
        Console.Write("Please enter your bank name: ");
        string bankName = Console.ReadLine();
        Console.Clear();
        
        Console.Write("Please enter your IBAN: ");
        string iBAN = Console.ReadLine();
        Console.Clear();
        
        Console.WriteLine("Please enter three credit card numbers associated with the account");
        Console.Write("Please enter number of first credit card: ");
       
        long firstNumberCard = long.Parse(Console.ReadLine());
        Console.Clear();
        
        Console.Write("Please enter number of second credit card: ");
        long secondNumberCard = long.Parse(Console.ReadLine());
        Console.Clear();
        
        Console.Write("Please enter number of third credit card: ");
        long thirdNumberCard = long.Parse(Console.ReadLine());
        Console.Clear();

        Console.WriteLine(@"
Full name:                 {0}
Balance:                   {1}
Bank name:                 {2}
IBAN:                      {3}
First credit card number:  {4}
Second credit card number: {5}
Third credit card number:  {6}" 
                               ,fullName, balance, bankName, iBAN, firstNumberCard, secondNumberCard, thirdNumberCard);
  
    }
}

