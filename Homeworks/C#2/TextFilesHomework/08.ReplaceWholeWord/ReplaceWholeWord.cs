/*
Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
*/ 


using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceWholeWordProblem
{
    class ReplaceWholeWord
    {
        static void Main()
        {
            try
            {
                using (StreamReader input = new StreamReader("Input.txt"))
                {
                    using (StreamWriter output = new StreamWriter("Output.txt"))
                    {
                        string line;
                        while ((line = input.ReadLine()) != null)
                        {
                            line = line.ToLower();
                            line = Regex.Replace(line, @"\bstart\b", "finish");
                            output.WriteLine(line);
                        }
                    }
                }

                Console.WriteLine("The words are replaced!");
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
