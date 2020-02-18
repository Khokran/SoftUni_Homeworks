using System;
using System.Collections.Generic;
using System.Text;

namespace StackOfStrings
{
    public class StackOfString : Stack<string>
    {
        public bool isEmpty()
        {
            return this.Count == 0;
        }
        public void AddRange(Stack<string> strings)
        {
            foreach (var str in strings)
            {
                this.Push(str);
            }
        }
    }
}
