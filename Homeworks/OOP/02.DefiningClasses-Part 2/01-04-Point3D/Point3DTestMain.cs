namespace Point3D
{
    using System;
    /* 
     Problem 1. Structure
       Create a structure `Point3D` to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
       Implement the `ToString()` to enable printing a 3D point.
     Problem 2. Static read-only field
       Add a `private static read-only` field to hold the start of the coordinate system – the point O{0, 0, 0}.
       Add a static property to return the point O.
     Problem 3. Static class
       Write a `static class` with a `static method` to calculate the distance between two points in the 3D space.
     Problem 4. Path
       Create a class `Path` to hold a sequence of points in the 3D space.
       Create a static class `PathStorage` with static methods to save and load paths from a text file.
       Use a file format of your choice.
    */ 

    class Point3DTestMain
    {
        static void Main()
        {
           Point3D point1 = new Point3D(2, 4, 3); 
           Point3D point2 = new Point3D(2, 4, 7);
           Point3D point3 = new Point3D(1, 7, 4);
           Point3D point4 = new Point3D(3, 6, 9);
           Point3D point5 = new Point3D(2, 8, 7);

           Path testPath = new Path(); 

           testPath.AddPoint(point1);
           testPath.AddPoint(point2);
           testPath.AddPoint(point3);
           testPath.AddPoint(point4);
           testPath.AddPoint(point5);

           PathStorage.SavePath(testPath, "test");


            Path loadedPath = PathStorage.LoadPath(@"../../test.txt");

            for (int i = 0; i < loadedPath.Sequence.Count; i++)
            {
                Console.WriteLine(loadedPath.Sequence[i]);
            }
        }
    }
}
