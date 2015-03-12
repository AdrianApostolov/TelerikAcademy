namespace GSMProblem
{
    using System;

    public class Display
    {
        private double size;
        private int numberOfColors;

        public Display(double size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Display size should be longer than 0");
                }
                else
                {
                    this.size = value;
                }
            }
        }

        public int NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Number of colors should be longer than 0");
                }
                else
                {
                    this.numberOfColors = value;
                }
            }
        }
    }
}
