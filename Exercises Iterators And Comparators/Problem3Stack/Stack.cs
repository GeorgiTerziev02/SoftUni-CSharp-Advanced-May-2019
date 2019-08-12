using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problem3Stack
{
    public class Stack : IEnumerable<int>
    {
        private List<int> collection;

        public Stack()
        {
            this.collection = new List<int>();
        }

        public void Push(int[] elements)
        {
            foreach (var el in elements)
            {
                this.collection.Add(el);
            }
        }

        public void Pop()
        {
            if (this.collection.Count != 0)
            {
                this.collection.RemoveAt(collection.Count - 1);
            }
            else Console.WriteLine("No elements");
        }

        public IEnumerator<int> GetEnumerator()
        {
            if (this.collection.Count != 0)
            {
                for (int i = this.collection.Count - 1; i >= 0; i--)
                {
                    yield return this.collection[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
