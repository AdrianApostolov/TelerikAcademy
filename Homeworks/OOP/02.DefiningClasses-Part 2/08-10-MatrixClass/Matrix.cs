namespace MatrixClass
{
    using System;
    using System.Text;

    public class Matrix<T>
    {
        private int rows;
        private int cols;
        private int[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new int[rows, cols];
        }

        public int Rows
        {
            get 
            { 
                return this.rows;
            }

            set
            {
                if (value < 0 && value > int.MaxValue) 
                {
                    throw new ArgumentException("Rows cannot be negative or more than int.MaxValue!");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get 
            { 
                return this.cols; 
            }

            set
            {
                if (value < 0 && value > int.MaxValue)
                {
                    throw new ArgumentException("Cols cannot be negative or more than int.MaxValue!");
                }

                this.cols = value;
            }
        }

        public int this[int rowIndex, int colIndex]
        {
            get
            {
                return this.matrix[rowIndex, colIndex];
            }

            set
            {
                if (rowIndex < 0 || rowIndex >= this.Rows || colIndex < 0 || colIndex >= this.Cols)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }

                this.matrix[rowIndex, colIndex] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows || firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("The rows and colums of the two matrices must be equals");
            }

            Matrix<T> result = new Matrix<T>(firstMatrix.Rows, firstMatrix.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = firstMatrix[row, col] + secondMatrix[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("The rows and colums of the two matrices must be equals");
            }

            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = first[row, col] - second[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException("The rows and colums of the two matrices must be equals");
            }

            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = first[row, col] * second[row, col];
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    result.Append(string.Format("{0, 5}", this.matrix[row, col]));
                }
                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
