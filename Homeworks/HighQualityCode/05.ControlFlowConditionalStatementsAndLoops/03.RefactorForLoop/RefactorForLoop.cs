namespace RefactorForLoop
{
    using System;

    class RefactorForLoop
    {
        static void Main()
        {
            int[] collection = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int valueForSearching = 4;

            SearchNumberInColection(collection, valueForSearching);
        }

        public static void SearchNumberInColection(int[] numbers, int expectedValue)
        {
            bool isFound = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentValue = numbers[i];

                if (currentValue == expectedValue)
                {
                    isFound = true;
                }

                Console.WriteLine(currentValue);
            }

            if (isFound)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
