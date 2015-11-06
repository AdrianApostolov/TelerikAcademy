namespace HashSetImplemetation
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using HashTableImplementation;

    public class MyHashSet<T> : IMyHashSet<T>, IEnumerable, IEnumerable<T> where T : IComparable<T>
    {
        private readonly MyHashTable<T, bool> elements;

        public MyHashSet()
        {
            this.elements = new MyHashTable<T, bool>();
        }

        public MyHashSet(IEnumerable<T> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection cannot be null.");
            }

            this.elements = new MyHashTable<T, bool>();

            foreach (var item in collection)
            {
                this.Add(item);
            }
        }

        public int Count
        {
            get
            {
                return this.elements.Count;
            }
        }

        public IEnumerable<T> Keys
        {
            get
            {
                var keys = new List<T>(this.elements.Keys);
                return keys;
            }
        }

        public bool Add(T item)
        {
            if (this.Contains(item))
            {
                return false;
            }

            this.elements.Add(item, true);

            return true;
        }

        public bool Contains(T item)
        {
            return this.elements.ContainsKey(item);
        }

        public bool Remove(T item)
        {
            return this.elements.Remove(item);
        }

        public void Clear()
        {
            this.elements.Clear();
        }

        public void UnionWith(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("Collection for union cannot be null.");
            }

            foreach (var item in other)
            {
                this.Add(item);
            }
        }

        public void IntersectWith(IEnumerable<T> other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("Collection for intersect cannot be null.");
            }

            var otherHashSet = new MyHashSet<T>(other);

            foreach (var item in this.Keys)
            {
                if (!otherHashSet.Contains(item))
                {
                    this.Remove(item);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in this.Keys)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
