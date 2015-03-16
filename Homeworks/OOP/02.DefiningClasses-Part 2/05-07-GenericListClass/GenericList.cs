namespace GenericList
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        private const int DefaultCapacity = 4;
        private const string IndexOutOfRangeExceptionMessage = "Invalid index.";

        private T[] listToArray;
        private int count;
        private int capacity;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Capacity = capacity;
            this.listToArray = new T[capacity];
            this.Count = 0;
        }

        public int Count
        {
            get
            {
                return this.count;
            }

            set
            {
                this.count = value;
            }
        }

        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            set
            {
                this.capacity = value;
            }
        }

        public T this[int index]
        {
            get
            {
                return this.listToArray[index];
            }

            set
            {
                this.listToArray[index] = value;
            }
        }

        public void Add(T element)
        {
            if (this.Count >= this.listToArray.Length)
            {
                this.DoubleSize();
            }

            this.listToArray[Count] = element;
            this.Count++;
            this.Capacity = this.listToArray.Length;
        }

        public void Remove(int index)
        {
            if (index < 0 || index > this.Count)
            {
                throw new IndexOutOfRangeException(IndexOutOfRangeExceptionMessage);
            }
            
            T[] curr = new T[this.Capacity - 1];

            for (int i = 0; i < index; i++)
            {
                curr[i] = this.listToArray[i];
            }

            for (int i = index; i < this.listToArray.Length - 1; i++)
            {
                curr[i] = this.listToArray[i + 1];
            }

            this.Count--;
            this.listToArray = curr;
            this.Capacity = this.listToArray.Length;
        }

        public void Insert(T element, int index)
        {
            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(IndexOutOfRangeExceptionMessage);
            }

            if (this.Count >= this.listToArray.Length - 1)
            {
                this.DoubleSize();
            }

            this.Capacity++;
            T[] curr = new T[capacity];
            for (int i = 0; i < curr.Length; i++)
            {
                if (i != index && i < curr.Length - 1)
                {
                    curr[i] = this.listToArray[i];
                }
                else if (i == index)
                {
                    curr[i] = element; 
                }
            }
            this.Count++;
            this.listToArray = curr;
            this.Capacity = listToArray.Length;
        }

        public void Clear()
        {
            this.Count = 0;
            this.Capacity = DefaultCapacity;
            this.listToArray = new T[this.Capacity];
        }

        public int Find(T value)
        {
            for (int i = 0; i < this.listToArray.Length; i++)
            {
                if (this.listToArray[i].Equals(value))
                {
                    return i;
                }
                else
                {
                    continue;
                }
            }
            return -1;
        }

        public T Min()
        {
            T min = this.listToArray[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.listToArray[i].CompareTo(min) < 0)
                {
                    min = this.listToArray[i];
                }
            }

            return min;
        }

        public T Max()
        {
            T max = this.listToArray[0];
            for (int i = 1; i < this.Count; i++)
            {
                if (this.listToArray[i].CompareTo(max) > 0)
                {
                    max = this.listToArray[i];
                }
            }

            return max;
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "The list is empty!";
            }

            StringBuilder result = new StringBuilder();
            result.Append("Element(s): ");
            for (int i = 0; i < this.Count; i++)
            {
                result.AppendFormat("{0}", this.listToArray[i]);
                if (i + 1 < this.Count)
                {
                    result.Append(", ");
                }
            }

            return result.ToString();
        }

        private void DoubleSize()
        {
            T[] newArr = new T[this.listToArray.Length * 2];
            for (int i = 0; i < this.listToArray.Length; i++)
            {
                newArr[i] = listToArray[i];
            }

            this.listToArray = newArr;
        }
    }
}
