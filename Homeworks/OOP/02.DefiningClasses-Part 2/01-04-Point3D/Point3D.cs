namespace Point3D
{
    public struct Point3D
    {
        private static readonly Point3D StartPoit = new Point3D(0, 0, 0);
        private int x;
        private int y;
        private int z;

        public Point3D(int x, int y, int z)
            : this() 
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public int X
        {
            get
            {
                return this.x; 
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }

            set
            {
                this.y = value;
            }
        }

        public int Z
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }

        public static Point3D O
        {
            get
            {
                return StartPoit;
            }
        }


        public override string ToString()
        {
            return string.Format("3DPoint({0}, {1}, {2})", this.X, this.Y, this.Z);
        }
    }
}
