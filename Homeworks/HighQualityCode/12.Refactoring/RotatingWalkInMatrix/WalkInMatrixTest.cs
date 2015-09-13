namespace RotatingWalkInMatrix
{
    using System;
    using Helper;

    public class WalkInMatrixTest
    {
        public static void Main()
        {
            int sizeOfMatrix = HelperMethods.ReadInput();
            var matrix = WalkInMatrix.GenerateMatrix(sizeOfMatrix);
            HelperMethods.PrintMatrixOnConsole(matrix);
        }
    }
}
