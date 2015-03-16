/*
Problem 11. Version attribute

Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11).
Apply the version attribute to a sample class and display its version at runtime.
*/ 

namespace VersionAttribute
{
    using System;

    [VersionAttribute("1.05")]
    class VersionAttributeMain
    {
        static void Main()
        {
            object[] attributes = typeof(VersionAttributeMain).GetCustomAttributes(false);
            Console.WriteLine(attributes[0]);
        }
    }
}
