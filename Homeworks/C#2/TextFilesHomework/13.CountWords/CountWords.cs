/*
Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
*/ 


using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace CountWordsProblem
{
    class CountWords
    {
        static void Main()
        {
            try
            {
                string[] listedWords = File.ReadAllLines(@"D:\Projects\TextFilesHomework\13.CountWords\bin\Debug\words.txt", 
                    Encoding.GetEncoding("windows-1251"));
                int[] counter = new int[listedWords.Length];

                using (StreamReader reader = new StreamReader(@"D:\Projects\TextFilesHomework\13.CountWords\bin\Debug\test.txt", 
                    Encoding.GetEncoding("windows-1251")))
                {
                    int lineNumber = 0;
                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        lineNumber++;

                        for (int index = 0; index < listedWords.Length; index++)
                        {
                            counter[index] += ((Regex
                                .Matches(line, @"\b" + listedWords[index] + @"\b").Count));
                        }

                        line = reader.ReadLine();
                    }
                }

                Array.Sort(counter, listedWords);

                using (StreamWriter writer = new StreamWriter(@"D:\Projects\TextFilesHomework\13.CountWords\bin\Debug\result.txt"))
                {
                    for (int index = listedWords.Length - 1; index >= 0; index--)
                    {
                        writer.WriteLine("{0}: {1}", listedWords[index], counter[index]);
                    }

                    Console.WriteLine("result.txt - Done !");
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
