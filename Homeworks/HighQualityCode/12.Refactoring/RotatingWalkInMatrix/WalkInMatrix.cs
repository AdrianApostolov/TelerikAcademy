namespace RotatingWalkInMatrix
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class WalkInMatrix
    {
        private const int DirectionsCount = 8;
        private static readonly int[] DirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
        private static readonly int[] DirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

        public static int[,] GenerateMatrix(int size)
        {
            int[,] matrix = new int[size, size];

            Cell startCell = FindFirstEmptyCell(matrix);

            if (startCell != null)
            {
                FillMatrix(matrix, startCell);
            }

            return matrix;
        }

        private static void FillMatrix(int[,] matrix, Cell startCell)
        {
            var currentCell = startCell;
            int direction = (int)Directions.DownRight;

            while (IsCellAvailable(matrix, currentCell))
            {
                matrix[currentCell.X, currentCell.Y] = currentCell.CellValue;

                while (!IsNextCellAvailable(matrix, currentCell, direction) &&
                       HasPossibleWalk(matrix, currentCell, direction))
                {
                    direction = (direction + 1) % DirectionsCount;
                }
                
                currentCell.X += DirX[direction];
                currentCell.Y += DirY[direction];
                currentCell.CellValue++;
            }

            var nextStartCell = FindFirstEmptyCell(matrix);
            if (nextStartCell != null)
            {
                nextStartCell.CellValue = currentCell.CellValue;
                FillMatrix(matrix, nextStartCell);
            }
        }

        private static Cell FindFirstEmptyCell(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Cell firstEmptyCell = new Cell(row, col);
                        return firstEmptyCell;
                    }
                }
            }

            return null;
        }

        private static bool IsCellAvailable(int[,] matrix, Cell currentCell)
        {
            bool isCellAvailable = currentCell.X >= 0 && currentCell.X < matrix.GetLength(0) &&
                                   currentCell.Y >= 0 && currentCell.Y < matrix.GetLength(1) &&
                                   matrix[currentCell.X, currentCell.Y] == 0;

            return isCellAvailable;
        }

        private static bool IsNextCellAvailable(int[,] matrix, Cell currentCell, int direction)
        {
            var nextX = currentCell.X + DirX[direction];
            var nextY = currentCell.Y + DirY[direction];
            var nextCell = new Cell(nextX, nextY);

            return IsCellAvailable(matrix, nextCell);
        }

        private static bool HasPossibleWalk(int[,] matrix, Cell currentCell, int direction)
        {
            for (int i = 0; i < DirectionsCount; i++)
            {
                direction = (direction + 1) % DirectionsCount;

                if (IsNextCellAvailable(matrix, currentCell, direction))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
