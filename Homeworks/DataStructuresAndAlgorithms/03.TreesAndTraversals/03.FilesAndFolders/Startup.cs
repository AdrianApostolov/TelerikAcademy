using System.Text;

namespace FilesAndFolders
{
    public class Startup
    {
        static void Main()
        {
            var entryPoint = new Folder("Help", @"C:\Windows\Help");
            GetSubFolders(entryPoint);
            StringBuilder sb = new StringBuilder();
            GetFileSystemString(entryPoint, sb, 0);
            System.Console.WriteLine(sb);
        }

        private static void GetFileSystemString(Folder folder, StringBuilder sb, int depth)
        {
            string indent = new string('*', depth * 3);

            sb.AppendLine(string.Format("{0}{1} size: {2}", indent, folder.Name, folder.GetSize()));

            foreach (var file in folder.Files)
            {
                sb.AppendLine(string.Format("{0}-{1} size: {2}", indent, file.Name, file.Size));
            }

            foreach (var subFolder in folder.Folders)
            {
                GetFileSystemString(subFolder, sb, depth + 1);
            }
        }

        private static void GetSubFolders(Folder folder)
        {
            foreach (var file in folder.Directory.GetFiles())
            {
                folder.Files.Add(new File(file.Name, file.Length));
            }

            foreach (var subDir in folder.Directory.GetDirectories())
            {
                var subFolder = new Folder(subDir.Name, subDir.FullName);
                folder.Folders.Add(subFolder);
                GetSubFolders(subFolder);
            }
        }
    }
}
