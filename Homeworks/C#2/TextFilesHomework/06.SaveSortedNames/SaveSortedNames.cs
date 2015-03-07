/*
Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	output.txt
Ivan          George
Peter          Ivan 
Maria          Maria 
George	       Peter
*/


using System;
using System.IO;
using System.Collections.Generic;

namespace SaveSortedNamesProblem
{
    class SaveSortedNames
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader input = new StreamReader("Input.txt"))
                {
                    List<string> names = new List<string>();

                    for (string currentName = input.ReadLine(); currentName != null; currentName = input.ReadLine())
                    {
                        names.Add(currentName);
                    }

                    names.Sort();

                    using (StreamWriter result = new StreamWriter("Output.txt"))
                    {
                        foreach (var name in names)
                        {
                            result.WriteLine(name);
                        }
                    }
                }
                Console.WriteLine("Names are sorted and save in Output.txt!");
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
