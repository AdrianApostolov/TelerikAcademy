namespace ExtraxtPricesXPath
{
    using System;
    using System.Xml;

    class StartProgram
    {
        static void Main()
        {
            XmlDocument document = new XmlDocument();
            document.Load("../../catalog.xml");

            var query = "/catalog/album[year>2000]/name";

            var albumNames = document.SelectNodes(query);

            foreach (XmlNode name in albumNames)
            {
                Console.WriteLine("Name: {0}", name.InnerText);
            }
        }
    }
}
