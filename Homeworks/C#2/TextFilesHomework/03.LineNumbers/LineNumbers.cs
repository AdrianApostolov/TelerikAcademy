/*
Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
*/


using System;
using System.Text;
using System.IO;

namespace LineNumbersProblem
{
    class LineNumbers
    {
        static void Main()
        {
            System.Text.Encoding encodingCyrillic = System.Text.Encoding.UTF8;

            try
            {
                StreamReader reader = new StreamReader("TextFile.txt", encodingCyrillic);
                StreamWriter writer = new StreamWriter("ResultFile.txt", true, encodingCyrillic);

                using (reader)
                {
                    using (writer)
                    {
                        string readLine = reader.ReadLine();
                        int countLine = 0;

                        while (readLine != null)
                        {
                            countLine++;
                            writer.WriteLine("{0}: {1}", countLine, readLine);
                            readLine = reader.ReadLine();
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
