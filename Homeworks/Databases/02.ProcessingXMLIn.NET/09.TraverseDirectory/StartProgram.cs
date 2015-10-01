namespace TraverseDirectory
{
    using System;
    using System.IO;
    using System.Text;
    using System.Xml;

    class StartProgram
    {
        static void Main()
        {
            using (XmlTextWriter writer = new XmlTextWriter("../../directories.xml", Encoding.UTF8))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = ' ';
                writer.Indentation = 4;

                string programsPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms);

                writer.WriteStartDocument();
                writer.WriteStartElement("Desktop");
                Traverse(programsPath, writer);
                writer.WriteEndDocument();
            }

            Console.WriteLine("XML documents created!");
        }

        static void Traverse(string dir, XmlTextWriter writer)
        {
            foreach (var directory in Directory.GetDirectories(dir))
            {
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("path", directory);
                Traverse(directory, writer);
                writer.WriteEndElement();
            }

            foreach (var file in Directory.GetFiles(dir))
            {
                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", Path.GetFileNameWithoutExtension(file));
                writer.WriteAttributeString("ext", Path.GetExtension(file));
                writer.WriteEndElement();
            }
        }
    }
}