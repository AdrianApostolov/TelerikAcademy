using System;

class CheckForPlayCard
{
    static void Main()
    {
        Console.Write("Please, enter character of a play card: ");
        string playCard = Console.ReadLine();
        string[] playCards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        if (Array.IndexOf(playCards, playCard) >= 0)
        {
            Console.WriteLine("Valid card sign?: Yes");
        }
        else
        {
            Console.WriteLine("Valid card sign?: No");
        }


    }
}
