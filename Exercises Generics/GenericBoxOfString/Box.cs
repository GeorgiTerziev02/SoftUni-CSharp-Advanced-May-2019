using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBoxOfString
{
    public class Box <T>
        where T:IComparable<T>
    {
        private List<T> boxCollection;

        public Box()
        {
            this.boxCollection = new List<T>();
        }

        public int CountGreater
        {
            get; private set;
        }
        public void Add(T name)
        {
            this.boxCollection.Add(name);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in boxCollection)
            {
                sb.AppendLine($"{item.GetType().FullName}: {item}");
            }

            return sb.ToString().TrimEnd();
        }

        public List<T> Swap(int i1,int i2)
        {
            T toSwap = boxCollection[i1];
            boxCollection[i1] = boxCollection[i2];
            boxCollection[i2] = toSwap;

            return boxCollection;
        }

        public void Compare(T item)
        {
            foreach (var currentItem in this.boxCollection)
            {
                if (currentItem.CompareTo(item)>0)
                {
                    CountGreater++;
                }
            }
        }
    }
}
