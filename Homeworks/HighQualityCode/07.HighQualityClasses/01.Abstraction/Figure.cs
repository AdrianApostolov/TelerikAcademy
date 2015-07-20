namespace Abstraction
{
    using System;
    using System.Text;

    public abstract class Figure : IFigure
    {
        public Figure()
        {
        }

        public abstract double CalculatePerimeter();

        public abstract double CalculateSurface();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("{0}", this.GetType().Name);
            sb.AppendLine();
            sb.AppendFormat("Area: {0:F2}, Perimeter: {1:F2}", this.CalculateSurface(), this.CalculatePerimeter());

            return sb.ToString();
        }
    }
}
