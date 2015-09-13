namespace RotatingWalkInMatrix.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;


    [TestClass]
    public class RotatingWalkInMatrixTests
    {
        [TestMethod]
        public void MatrixShouldReturnCorrectMatrixOfSize1()
        {
            int size = 1;
            var expectedMatrix = new int[,]
            {
                { 1 }
            };
            var actualMatrix = WalkInMatrix.GenerateMatrix(size);

            var areMatrixesEqual = AreMatricesEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEqual);
        }

        [TestMethod]
        public void MatrixShouldReturnCorrectMatrixOfSize2()
        {
            int size = 2;
            var expectedMatrix = new int[,]
            {
                
                { 1, 4 },
                { 3, 2 }
            };
            var actualMatrix = WalkInMatrix.GenerateMatrix(size);

            var areMatrixesEqual = AreMatricesEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEqual);
        }

        [TestMethod]
        public void MatrixShouldReturnCorrectMatrixOfSize3()
        {
            int size = 3;
            var expectedMatrix = new int[,]
            {
                { 1, 7, 8 },
                { 6, 2, 9 },
                { 5, 4, 3 }
            };
            var actualMatrix = WalkInMatrix.GenerateMatrix(size);

            var areMatrixesEqual = AreMatricesEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEqual);
        }

        [TestMethod]
        public void MatrixShouldReturnCorrectMatrixOfSize6()
        {
            int size = 6;
            var expectedMatrix = new int[,]
            {
                { 1, 16, 17, 18, 19, 20 },
                { 15, 2, 27, 28, 29, 21 },
                { 14, 31, 3, 26, 30, 22 },
                { 13, 36, 32, 4, 25, 23 },
                { 12, 35, 34, 33, 5, 24 },
                { 11, 10, 9, 8, 7, 6 }
            };
            var actualMatrix = WalkInMatrix.GenerateMatrix(size);

            var areMatrixesEqual = AreMatricesEqual(expectedMatrix, actualMatrix);
            Assert.IsTrue(areMatrixesEqual);
        }



        private bool AreMatricesEqual(int[,] expectedMatrix, int[,] actualMatrix)
        {
            for (int row = 0; row < expectedMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < expectedMatrix.GetLength(1); col++)
                {
                    if (expectedMatrix[row, col] != actualMatrix[row, col])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
