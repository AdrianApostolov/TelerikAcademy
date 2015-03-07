/*
Problem 10. Extract text from XML

Write a program that extracts from given XML file all the text without the tags.
Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
*/ 


using System;
using System.IO;

namespace ExtractTextFromXMLProblem
{
    class ExtractTextFromXML
    {
        static void Main()
        {
            try
            {
                using (StreamReader reader = new StreamReader("XML.txt"))
                {
                    string line = reader.ReadLine();
                    string extract = string.Empty;
                    while (line != null)
                    {
                        for (int i = 1; i < line.Length; i++)
                        {
                            if (line[i - 1] == '>')
                            {
                                while (line[i] != '<')
                                {
                                    extract += line[i];
                                    i++;
                                }
                                if (extract != string.Empty)
                                {
                                    Console.WriteLine(extract.TrimStart(' '));
                                    extract = string.Empty;
                                }
                            }
                        }
                        line = reader.ReadLine();
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