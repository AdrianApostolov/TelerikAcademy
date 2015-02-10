using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Please, enter your score in the range 1 to 09: ");
        int score = int.Parse(Console.ReadLine());

        if (score >= 1 && score <= 3)
        {
            Console.WriteLine("Your bonus score is: " + score * 10);
        }
        else if (score >= 4 && score <= 6)
        {
            Console.WriteLine("Your bonus score is: " + score * 100);
        }
        else if (score >= 7 && score <= 9)
        {
            Console.WriteLine("Your bonus score is: " + score * 1000);
        }
        else if (score <= 0 || score >= 9)
        {
            Console.WriteLine("Invalid score!");
        }
    }
}

