/*
Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
*/ 


using System;
using System.Net;
using System.Threading;

namespace DownloadFileProblem
{
    class DownloadFile
    {
        static void Main()
        {
            using (WebClient webClient = new WebClient())
            {
                try
                {
                    Console.WriteLine("Downloading file, please wait...");
                    webClient.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "news-img01.png");
                    Thread.Sleep(3000);
                    Console.WriteLine("File was downloaded successfully in 'bin' directory of the project!");
                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (WebException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                finally
                {
                    Console.WriteLine("Goodbye!");
                }

                
            }
        }
    }
}
