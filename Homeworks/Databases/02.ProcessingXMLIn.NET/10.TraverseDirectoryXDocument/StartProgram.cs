namespace TraverseDirectoryXDocument
{
    using System;
    using System.IO;
    using System.Xml.Linq;

    class StartProgram
    {
        static void Main()
        {
            var programsPath = Traverse(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms));
            programsPath.Save("../../directories.xml");

            Console.WriteLine("XML documents created!");
        }

        static XElement Traverse(string dir)
        {
            var element = new XElement("dir", new XAttribute("path", dir));

            foreach (var directory in Directory.GetDirectories(dir))
            {
                element.Add(Traverse(directory));
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                element.Add(new XElement("file",
                    new XAttribute("name", Path.GetFileNameWithoutExtension(file)),
                    new XAttribute("ext", Path.GetExtension(file))));
            }

            return element;
        }
    }
}