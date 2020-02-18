using System;
using System.Collections.Generic;
using System.Text;

namespace ExGenericCountMethodStrings
{
    public class Box<TItem>
        where TItem : IComparable<TItem>
    {
        private List<TItem> boxCollection;
        public Box()
        {
            this.boxCollection = new List<TItem>();
        }
        public int CountGreater { get; private set; }
        public void Add(TItem item)
        {
            this.boxCollection.Add(item);
        }
        public void Compare(TItem item)
        {
            foreach (var currItem in boxCollection)
            {
                if (currItem.CompareTo(item) > 0)
                {
                    this.CountGreater++;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var text in this.boxCollection)
            {
                sb.AppendLine($"{text.GetType().FullName}: {text}");
            }

            return base.ToString().TrimEnd();
        }

    }
}
