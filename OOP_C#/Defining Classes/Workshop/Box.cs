using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Workshop_LAB
{
    /// <summary>
    /// Generate a box
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Box<T>
    {
        private List<T> boxItems;
        /// <summary>
        /// Generate a Count
        /// </summary>
        public int Count
        {
            get
            {
                return boxItems.Count;
            }
        }
        public Box()
        {
            boxItems = new List<T>();
        }
        public void Add(T element)
        {
            boxItems.Add(element);
        }
        public T Remove()
        {
            if (Count > 0)
            {
                T lastElement = boxItems.Last();
                boxItems.RemoveAt(Count - 1);

                return lastElement;
            }
            throw new InvalidOperationException("Can no remove element from empty collection");
        }
    }
}
