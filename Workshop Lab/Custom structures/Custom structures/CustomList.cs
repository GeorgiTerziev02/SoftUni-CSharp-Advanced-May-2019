using System;
using System.Collections.Generic;
using System.Text;

namespace Custom_structures
{
    /// <summary>
    /// Integer List
    /// </summary>
    public class CustomList
    {  /// <summary>
       /// Default size of array
       /// </summary>
        private const int defaultSize = 2;

        /// <summary>
        /// internal array
        /// </summary>
        private int[] innerArr;

        /// <summary>
        /// Number of elements in the list
        /// </summary>
        public int Count { get; private set; } = 0;

        /// <summary>
        /// Creates custom integer list with default size
        /// </summary>
        public CustomList()
        {
            innerArr = new int[defaultSize];
        }

        /// <summary>
        /// Creates custom integer list with initial size
        /// </summary>
        /// <param name="initialSize">Initial size
        /// of the list</param>
        public CustomList(int initialSize)
        {
            innerArr = new int[initialSize];
        }

        public void Add(int element)
        {
            if (innerArr.Length == Count)
            {
                Grow();
            }

            innerArr[Count] = element;
            Count++;
        }

        public void AddRang(int[] list)
        {
            if (list.Length + Count >= innerArr.Length)
            {
                if (list.Length + Count > innerArr.Length * 2)
                {
                    Grow(list.Length + Count);
                }
                else
                {
                    Grow();
                }
            }

            for (int i = 0; i < list.Length; i++)
            {
                innerArr[Count] = list[i];
                Count++;
            }

        }
        /// <summary>
        /// Removes element at position
        /// </summary>
        ///<param name="index">position</param>
        public void RemoveAt(int index)
        {
            if(index<0||index>Count-1)
            {
                throw new IndexOutOfRangeException();
            }

        }

        #region private
        private void Grow()
        {
            Grow(innerArr.Length * 2);
        }
        private void Grow(int newSize)
        {
            int[] tempArr = new int[newSize];

            innerArr.CopyTo(tempArr, 0);
            innerArr = tempArr;
        }

        #endregion

    }
}
