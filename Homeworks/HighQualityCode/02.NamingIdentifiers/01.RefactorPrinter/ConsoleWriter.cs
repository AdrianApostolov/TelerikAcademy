namespace RefactorPrinter
{
    using System;

    class ConsoleWriterTest
    {
        const int MaxCount = 6;

        public static void Main()
        {
            ConsoleWriter consoleWriter = new ConsoleWriter();
            consoleWriter.PrintBoolean(true);

        }
    }
}
