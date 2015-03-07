/*
Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
*/ 


using System;
using System.IO;
using System.Text.RegularExpressions;

namespace RemoveWordsProblem
{
    class RemoveWords
    {
        static void Main()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("Output.txt"))
                {
                    using (StreamReader sr = new StreamReader("Input.txt"))
                    {
                        string line;
                        string regex = @"\b(" + String.Join("|", File.ReadAllLines("Input.txt")) + @")\b";
                        while ((line = sr.ReadLine()) != null)
                        {
                            line = line.ToLower();
                            line = Regex.Replace(line, regex, string.Empty);
                            sw.WriteLine(line);
                        }
                    }
                }
            }

            catch (System.IO.DirectoryNotFoundException ex)
            {
                Console.WriteLine("Part of a file or directory cannot be found.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.DriveNotFoundException ex)
            {
                Console.WriteLine("Trying to access a drive or share that is not available.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.EndOfStreamException ex)
            {
                Console.WriteLine("Reading is attempted past the end of a stream.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.FileLoadException ex)
            {
                Console.WriteLine("Managed assembly is found but cannot be loaded.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine("Attempt to access a file that does not exist on disk fails.");
                Console.WriteLine(ex.Message);
            }

            catch (System.IO.PathTooLongException ex)
            {
                Console.WriteLine("Path or file name is longer than the system-defined maximum length.");
                Console.WriteLine(ex.Message);
            }

            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("The program has no permissions to read the file!");
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("An unknown error occured!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
