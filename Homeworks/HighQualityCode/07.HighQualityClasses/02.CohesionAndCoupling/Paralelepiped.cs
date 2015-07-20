namespace CohesionAndCoupling
{
    using System;

    public class Paralelepiped
    {
        private const string InvalidWidthExceptionMessage = "Width cannot be less than or equal to 0.";
        private const string InvalidHeightExceptionMessage = "Height cannot be less than or equal to 0.";
        private const string InvalidDepthExceptionMessage = "Depth cannot be less than or equal to 0.";
        private double width;
        private double height;
        private double depth;

        public Paralelepiped(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(InvalidWidthExceptionMessage);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(InvalidHeightExceptionMessage);
                }

                this.height = value;
            }
        }

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(InvalidDepthExceptionMessage);
                }

                this.depth = value;
            }
        }

        public double CalculateVolume()
        {
            double volume = this.Width * this.Height * this.Depth;
            return volume;
        }

        public double CalculateDiagonalXYZ()
        {
            double distance = GeometryUtils.CalculateDistance3D(0, 0, 0, this.Width, this.Height, this.Depth);
            return distance;
        }

        public double CalculateDiagonalXY()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Width, this.Height);
            return distance;
        }

        public double CalculateDiagonalXZ()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Width, this.Depth);
            return distance;
        }

        public double CalculateDiagonalYZ()
        {
            double distance = GeometryUtils.CalculateDistance2D(0, 0, this.Height, this.Depth);
            return distance;
        }
    }
}
