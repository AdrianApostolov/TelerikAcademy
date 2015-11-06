namespace PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        private static Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

        public static void Main()
        {
            ReadPhonebookFromFile();

            Find("Kireto");
            Find("Mimi", "Plovdiv");
        }

        private static void ReadPhonebookFromFile()
        {
            using (var reader = new StreamReader("../../phonebook.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    var entries = line.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    var names = entries[0].Trim().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    string town = entries[1].Trim();

                    foreach (var item in names)
                    {
                        AddToPhoneBook(item, line);
                        AddToPhoneBook(item + " from " + town, line);
                    }
                    line = reader.ReadLine();
                }
            }
        }

        private static void AddToPhoneBook(string name, string line)
        {
            name = name.ToLower();
            List<string> entries;

            if (!phonebook.TryGetValue(name, out entries))
            {
                entries = new List<string>();
                phonebook.Add(name, entries);
            }
            entries.Add(line);
        }

        static void Find(string name)
        {
            string nameToSearch = name.Trim().ToLower();
            PrintAllMatches(nameToSearch);
        }

        static void Find(string name, string town)
        {
            string nameAndTown = name.ToLower() + " from " + town.ToLower();
            PrintAllMatches(nameAndTown);
        }

        static void PrintAllMatches(string key)
        {
            List<string> allMatches;
            if (phonebook.TryGetValue(key, out allMatches))
            {
                foreach (string entry in allMatches)
                {
                    Console.WriteLine(entry);
                }
            }
            else
            {
                Console.WriteLine("Not found!");
            }
            Console.WriteLine();
        }
    }
}
