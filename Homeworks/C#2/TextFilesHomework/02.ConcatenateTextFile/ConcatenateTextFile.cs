/*
Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
*/


using System;
using System.IO;
using System.Text;

namespace ConcatenateTextFileProblem
{
    class ConcatenateTextFile
    {
        static void Main()
        {
            System.Text.Encoding encodingCyrillic = System.Text.Encoding.UTF8;
            try
            {
                StreamReader firstPath = new StreamReader("FirstFile.txt", encodingCyrillic);
                StreamReader secondPath = new StreamReader("SecondFile.txt", encodingCyrillic);

                string readFirstFile = string.Empty;
                string readSecondFile = string.Empty;

                using (firstPath)
                {
                    readFirstFile = firstPath.ReadToEnd();
                }

                using (secondPath)
                {
                    readSecondFile = secondPath.ReadToEnd();
                }
                string concatenateFile = @"D:\Projects\TextFilesHomework\02.ConcatenateTextFile\bin\Debug\ConcatenateFile.txt";
                StreamWriter concatenatePath = new StreamWriter(concatenateFile);

                using (concatenatePath)
                {
                    concatenatePath.WriteLine(readFirstFile);
                    concatenatePath.WriteLine();
                    concatenatePath.WriteLine(readSecondFile);
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
