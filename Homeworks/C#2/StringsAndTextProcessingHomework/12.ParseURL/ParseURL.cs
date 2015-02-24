/*
Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

                       URL                                               Information
http://telerikacademy.com/Courses/Courses/Details/212	              [protocol] = http 
                                                                  [server] = telerikacademy.com 
                                                            [resource] = /Courses/Courses/Details/212 
*/

using System;

namespace ParseURLProblem   
{
    class ParseURL
    {
        static void Main()
        {
            Console.Write("Please enter URL addres: ");
            string url = Console.ReadLine();

            string protocol = url.Substring(0, url.IndexOf("://"));
            url = url.Substring(url.IndexOf("://") + 3);
            string server = url.Substring(0, url.IndexOf("/"));
            string resource = url.Substring(url.IndexOf("/"));
            Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}", protocol, server, resource);
        }
    }
}
