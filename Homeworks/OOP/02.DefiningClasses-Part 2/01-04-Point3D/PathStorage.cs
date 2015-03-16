namespace Point3D
{
    using System;
    using System.Linq;
    using System.IO;


    public static class PathStorage
    {
        public static void SavePath(Path path, string pathName)
        {
            StreamWriter writer = new StreamWriter("..//..//" + pathName + ".txt");

            using (writer)
            {
                for (int i = 0; i < path.Sequence.Count; i++)
                {
                    writer.WriteLine(path.Sequence[i]);
                }
            }
        }

        public static Path LoadPath(string filePath)
        {
            Path path = new Path();
            StreamReader reader = new StreamReader(filePath);

            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    int coordinatesStart = line.IndexOf("(");
                    string coordinates = line.Substring(coordinatesStart + 1, 7);

                    int[] pointCoordinates = coordinates.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x))
                        .ToArray();

                    Point3D point = new Point3D(pointCoordinates[0], pointCoordinates[1], pointCoordinates[2]);
                    path.AddPoint(point);

                    line = reader.ReadLine();
                }
            }

            return path;
        }


    }
}
