namespace DeleteAlbums
{
    using System;
    using System.Collections.Generic;
    using System.Xml;

    class Program
    {
        static void Main()
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../catalog.xml");
            var rootNode = document.DocumentElement;
            var maxPrice = 20;


            foreach (XmlNode album in rootNode.ChildNodes)
            {
                var priceNode = album["price"];
                var price = Double.Parse(priceNode.InnerText);

                if (price > maxPrice)
                {
                    rootNode.RemoveChild(album);
                }
            }

            document.Save("../../newCatalogue.xml");
            Console.WriteLine("Albums saved in newCatalogue.xml");
        }
    }
}