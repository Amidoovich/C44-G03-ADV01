using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01
{
    internal class FixedSizeList<T>
    {
        #region Attributes
        private int index;

        private T[] fixedList;

        #endregion

        #region properties
        public int Capacity { get; }

        #endregion

        #region Constructors
        public FixedSizeList(int capacity)
        {
            if(capacity <= 0)
                throw new ArgumentOutOfRangeException("Capacity must be greater than zero.");
            Capacity = capacity;
            fixedList = new T[Capacity];
            index = 0;
        }
        #endregion

        #region Methods

        public void Add(T item)
        {
            if (index >= Capacity)
                throw new InvalidOperationException("list is already full.");
            fixedList[index++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= this.index)
                throw new ArgumentOutOfRangeException("Index is out of range.");
            return fixedList[index];
        }
        #endregion

    }
}
