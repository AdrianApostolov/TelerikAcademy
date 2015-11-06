namespace TreesTraversals
{
    using System.Collections.Generic;

    public class Node<T>
    {
        public Node(T value)
        {
            this.Value = value;
            this.Children = new List<Node<T>>();
        }

        public T Value { get; set; }

        public List<Node<T>> Children { get; set; }

        public bool HasParent { get; set; }

        public bool HasChildren
        {
            get
            {
                return this.Children.Count > 0;
            }
        }

        public List<Node<T>> Depth
        {
            get
            {
                List<Node<T>> path = new List<Node<T>>();
                foreach (var node in this.Children)
                {
                    List<Node<T>> temp = node.Depth;
                    if (temp.Count > path.Count)
                        path = temp;
                }
                path.Insert(0, this);
                return path;
            }
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}
