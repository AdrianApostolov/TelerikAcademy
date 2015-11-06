namespace TraverseDirectories
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Startup
    {
        static void Main()
        {
            var entryPoint = new DirectoryInfo(@"C:\Windows");
            var result = new StringBuilder();
            Traverse(entryPoint, result);
            Console.WriteLine(result);
        }

        private static void Traverse(DirectoryInfo directory, StringBuilder output)
        {
            try
            {
                var exes = directory.GetFiles().Where(file => file.Extension == ".exe");
                foreach (var file in exes)
                {
                    output.AppendLine(file.Name);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot access {0}", directory.FullName);
                return;
            }

            foreach (var subDirectory in directory.GetDirectories())
            {
                Traverse(subDirectory, output);
            }
        }

    }
}