/*
Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
*/


using System;
using System.Collections.Generic;
using System.IO;

namespace DeleteOddLinesProblem
{
    class DeleteOddLines
    {
        static void Main()
        {
            try
            {
                List<string> evenLines = new List<string>();
                using (StreamReader reader = new StreamReader("Input.txt"))
                {
                    int lineNum = 1;
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (lineNum % 2 == 0)
                        {
                            evenLines.Add(line);
                        }
                        lineNum++;
                        line = reader.ReadLine();
                    }
                }
                using (StreamWriter output = new StreamWriter("Input.txt"))
                {
                    for (int i = 0; i < evenLines.Count; i++)
                    {
                        output.WriteLine(evenLines[i]);
                    }
                }

                Console.WriteLine("The odd lines are deleted!");
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
