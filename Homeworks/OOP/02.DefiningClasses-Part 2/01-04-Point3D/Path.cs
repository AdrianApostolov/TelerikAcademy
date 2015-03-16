namespace Point3D
{
    using System.Collections.Generic;

    public class  Path
    {
        private List<Point3D> sequence;

        public Path()
        {
            this.sequence = new List<Point3D>();
        }

        public List<Point3D> Sequence
        {
            get
            {
                return this.sequence;
            }
            set
            {
                this.sequence = value;
            }
        }

        public int Count
        {
            get
            {
                return this.sequence.Count;
            }
        }

        public void AddPoint(Point3D point)
        {
            this.sequence.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.sequence.Remove(point);
        }
    }
}
