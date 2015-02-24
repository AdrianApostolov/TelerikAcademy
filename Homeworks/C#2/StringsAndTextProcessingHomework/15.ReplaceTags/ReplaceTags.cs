/*
Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

input	
<p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	
 
 output
 <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>*/


using System;

namespace RppalceTagsProblem
{
    class ReplaceTags
    {
        static void Main()
        {
            string htmlDocument = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.";

            Console.WriteLine("HTML document:");
            Console.WriteLine(htmlDocument);
            htmlDocument = htmlDocument.Replace("<a href=\"", "[URL=");
            htmlDocument = htmlDocument.Replace("</a>", "[/URL]");
            htmlDocument = htmlDocument.Replace("\">", "]");
            Console.WriteLine();
            Console.WriteLine("Replaced HTML document:");
            Console.WriteLine(htmlDocument);
        }
    }
}
