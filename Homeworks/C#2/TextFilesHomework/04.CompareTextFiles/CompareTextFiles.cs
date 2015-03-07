/*
 Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.
*/


using System;
using System.Collections.Generic;
using System.IO;

namespace CompareTextFilesProblem
{
    class CompareTextFiles
    {
        static void Main()
        {
            System.Text.Encoding encodingCyrillic = System.Text.Encoding.UTF8;

            try
            {
                StreamReader firstFile = new StreamReader("FileOne.txt", encodingCyrillic);
                StreamReader secondFile = new StreamReader("FileTwo.txt", encodingCyrillic);

                string linesTextOne = firstFile.ReadLine();
                string linesTextTwo = secondFile.ReadLine();
                int count = 1;
                List<int> sameLines = new List<int>();
                List<int> differentLines = new List<int>();
                
                while (linesTextTwo != null)
                {
                    if (linesTextOne.Equals(linesTextTwo))
                    {
                        sameLines.Add(count);
                    }
                    else
                    {
                        differentLines.Add(count);
                    }
                    count++;
                    linesTextOne = firstFile.ReadLine();
                    linesTextTwo = secondFile.ReadLine();
                }
                Console.WriteLine("Same lines: {0}", string.Join(" ", sameLines));
                Console.WriteLine("Different lines: {0}", string.Join(" ", differentLines));

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

