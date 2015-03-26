namespace Shapes
{
    using System;

    public class Square : Shape
    {

        public Square(double width, double height)
            : base(width, height)
        {
            this.Height = this.Width;
        }

        public override double CalculateSurface()
        {
            return Math.Pow(this.Height, 2);
        }
    }
}
