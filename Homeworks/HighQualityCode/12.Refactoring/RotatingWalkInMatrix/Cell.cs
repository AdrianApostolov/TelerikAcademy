namespace RotatingWalkInMatrix
{
    using System;

    public class Cell
    {
        private const int InitialCellValue = 1;

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
            this.CellValue = InitialCellValue;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int CellValue { get; set; }
    }
}
