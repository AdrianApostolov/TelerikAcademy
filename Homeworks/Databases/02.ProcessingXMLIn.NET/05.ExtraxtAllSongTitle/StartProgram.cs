namespace _05.ExtraxtAllSongTitle
{
    using System;
    using System.Xml;

    class StartProgram
    {
        static void Main()
        {
            using (XmlReader reader = XmlReader.Create("../../catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element))
                    {
                        if (reader.Name == "title")
                        {
                            Console.WriteLine(reader.ReadElementString());
                        }
                    }
                }
            }
        }
    }
}
