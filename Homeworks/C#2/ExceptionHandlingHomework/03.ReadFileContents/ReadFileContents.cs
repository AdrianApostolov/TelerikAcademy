/*
Problem 3. Read file contents

Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
Find in MSDN how to use System.IO.File.ReadAllText(…).
Be sure to catch all possible exceptions and print user-friendly error messages.
*/


using System;
using System.IO;

namespace ReadFileContentsProblem
{
    class ReadFileContents
    {
        static void Main()
        {
            try
            {
                string path = "C:\\WINDOWS\\win.ini";
                string file = System.IO.File.ReadAllText(path);
                Console.WriteLine(file);
            }

            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Part of a file or directory cannot be found.");
            }

            catch (System.IO.DriveNotFoundException)
            {
                Console.WriteLine("Trying to access a drive or share that is not available.");
            }

            catch (System.IO.EndOfStreamException)
            {
                Console.WriteLine("Reading is attempted past the end of a stream.");
            }

            catch (System.IO.FileLoadException)
            {
                Console.WriteLine("Managed assembly is found but cannot be loaded.");
            }

            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Attempt to access a file that does not exist on disk fails.");
            }

            catch (System.IO.PathTooLongException)
            {
                Console.WriteLine("Path or file name is longer than the system-defined maximum length.");
            }

            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("The program has no permissions to read the file!");
            }

            catch (Exception ex)
            {
                Console.WriteLine("An unknown error occured!");
                throw ex;
            }
        }
    }
}
