using CreatePersonXML;
namespace CreatePersonXML
{
    using System;
    using System.IO;
    using System.Xml;
    using System.Xml.Linq;

    class StartProgram
    {
        static void Main()
        {
            var person = new Person();

            using (StreamReader sr = new StreamReader("../../person.txt"))
            {
                person.Name = sr.ReadLine();
                person.Phone = sr.ReadLine();
                person.Address = sr.ReadLine();
            }

            var personNode = new XElement("person",
                new XElement("name", person.Name),
                new XElement("phone", person.Phone),
                new XElement("address", person.Address));

            Console.WriteLine("Person saved as person.xml");
            personNode.Save("../../person.xml");
        }
    }
}
