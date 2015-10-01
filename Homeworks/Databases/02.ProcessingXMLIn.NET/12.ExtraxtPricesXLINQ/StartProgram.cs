namespace ExtraxtPricesXLINQ
{
    using System;
    using System.Linq;
    using System.Xml.Linq;

    class StartProgram
    {
        static void Main()
        {
            var document = XDocument.Load("../../catalog.xml");

            var albumNames = from album in document.Descendants("album")
                             where int.Parse(album.Element("year").Value) > 2000
                             select album.Element("name").Value;

            foreach (var name in albumNames)
            {
                Console.WriteLine("Name: {0}", name);
            }
        }
    }
}
