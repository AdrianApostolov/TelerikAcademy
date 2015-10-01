namespace XMLTransform
{
    using System.Xml.Xsl;

    class StartProgram
    {
        static void Main()
        {
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xslt");
            xslt.Transform("../../catalog.xml", "../../catalog.html");
        }
    }
}
