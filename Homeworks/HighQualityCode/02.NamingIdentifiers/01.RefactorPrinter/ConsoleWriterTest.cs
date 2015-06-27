namespace RefactorPrinter
{
    using System;

    class ConsoleWriter
    {
        public void PrintBoolean(bool value)
        {
            string boleanAsString = value.ToString();
            Console.WriteLine(boleanAsString);
        }
    }
}