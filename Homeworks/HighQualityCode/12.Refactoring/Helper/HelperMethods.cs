namespace Helper
{
    using System;

    public static class HelperMethods
    {
        public static int ReadInput()
        {
            Console.Write("Enter a positive number: ");
            string input = Console.ReadLine();

            int n;
            while (!int.TryParse(input, out n) || n <= 0 || n > 100)
            {
                Console.WriteLine("Invalid input: You haven't entered a correct positive number!");
                input = Console.ReadLine();
            }

            return n;
        }

        public static void PrintMatrixOnConsole(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLongLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLongLength(1); j++)
                {
                    Console.Write("{0,3} ", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
