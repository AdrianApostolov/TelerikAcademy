namespace Abstraction
{
    using System;
    using System.Text;

    public class Circle : Figure, IFigure
    {
        private const string InvalidRadiusExceptionMessage = "Radius cannot be less than or equal to 0.";
        private double radius;

        public Circle(double radius)
            : base()
        {
            this.radius = radius;
        }

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(InvalidRadiusExceptionMessage);
                }

                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(base.ToString());
            sb.AppendLine();
            sb.AppendFormat("Radius: {0}", this.Radius);

            return sb.ToString();
        }
    }
}
