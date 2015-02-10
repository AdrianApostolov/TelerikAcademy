using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                oddProduct *= numbers[i];
            }
            else
            {
                evenProduct *= numbers[i];
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("even product = {0}", evenProduct);
            Console.WriteLine("odd product = {0}", oddProduct);
        }
    }
}

