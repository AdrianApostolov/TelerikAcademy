namespace Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class ConsoleUtility
    {
        public static List<int> GetSequence()
        {
            Console.WriteLine("Enter integers sequence, separated by comma: ");
            return Console.ReadLine()
                          .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                          .Select(x => int.Parse(x))
                          .ToList();
        }
    }
}
