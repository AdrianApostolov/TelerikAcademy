namespace ExtensionMethods
{
    using System;

    class ExtensionMethodsTest
    {
        static void Main()
        {
            double[] numbers = new double[] { 52.2, -33.0, 8.2, 4.5, 0.5, 24.9, -10.9, 75.5 };
            numbers.PrintStatistics();
        }
    }
}
