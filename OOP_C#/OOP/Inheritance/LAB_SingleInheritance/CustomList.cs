using System;
using System.Collections.Generic;
using System.Text;

namespace LAB_SingleInheritance
{
    public class CustomList<T> : List<T>
    {
        public CustomList()
        {
            rand = new Random();
        }
        private Random rand;
        public T RemoveRandomElement()
        {
            int index = rand.Next(0, this.Count);

            T element = this[index];
            this.RemoveAt(index);

            return element;
        }
    }
}
