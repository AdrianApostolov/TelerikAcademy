/*
Problem 11. Prefix "test"

Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
*/ 


using System;
using System.IO;

namespace PrefixTestProblem
{
    class PrefixTest
    {
        static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader("Input.txt"))
                {
                    using (StreamWriter output = new StreamWriter("Output.txt"))
                    {
                        string line = reader.ReadLine();
                        while (line != null)
                        {
                            if ((line[0] == 't') && (line[1] == 'e') && (line[2] == 's') && (line[3] == 't'))
                            {
                                string wordWithoutPrefix = line.Substring(4);
                                output.WriteLine(wordWithoutPrefix);
                            }
                            line = reader.ReadLine();
                        }
                    }
                }
                Console.WriteLine("All words starting with prefix \"test\" removed.");
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
