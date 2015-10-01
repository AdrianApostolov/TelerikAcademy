namespace XsdSchema
{
    using System;
    using System.Xml.Linq;
    using System.Xml.Schema;

    class StartProgram
    {
        public static void Main()
        {
            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add(string.Empty, "../../catalog.xsd");

            XDocument validDoc = XDocument.Load("../../catalog.xml");
            XDocument invalidDoc = XDocument.Load("../../invalidCatalog.xml");
            ValidateXml(validDoc, schemas, "catalog.xml");
            ValidateXml(invalidDoc, schemas, "invalidCatalog.xml");
        }

        public static void ValidateXml(XDocument doc, XmlSchemaSet schema, string file)
        {
            doc.Validate(schema, (obj, ev) =>
            {
                Console.WriteLine("{0} - {1}", file, ev.Message);
            });
        }
    }
}
