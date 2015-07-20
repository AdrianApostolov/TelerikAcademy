namespace Abstraction
{
    using System;
    using System.Text;

    public class Rectangle : Figure, IFigure
    {
        private const string InvalidWidthExceptionMessage = "Width cannot be less than or equal to 0.";
        private const string InvalidHeightExceptionMessage = "Height cannot be less than or equal to 0.";
        private double width;
        private double height;

        public Rectangle(double width, double height)
            : base()
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
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

        public double Height
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

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.AppendLine();
            sb.AppendFormat("Width: {0}, Height: {1}", this.Width, this.Height);

            return sb.ToString();
        }
    }
}
