using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomListProj
{
    public class CustomList<T> : IEnumerable  where T : IComparable
    {                            // Non_Generic    // Adds a constraint to
        // _Private Member Variables
        // the _prefix is for private 
        private T[] _items;
        private int _count; //_size
        private int _size;

        // Sets IEnumerable to the _items generics array 

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _size; i++) // Don't exceed count
            {
                yield return _items[i];
            }

        }

        // Property
        public int Count { get { return _count; } }
        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public T this[int i] // Indexer 
        {
            get
            {
                if (i >= 0) // null
                {
                    return _items[i];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set { _items[i] = value; }
        }


        // Constructor
        public CustomList()
        {

            this._size = 4;
            _items = new T[_size];

            this._count = 0;

        }

        public void Add(T value)
        {

            if (_count == _size)
            {
                _items = Expander(_items);
                _items[_count++] = value;

            }
            else if (_count < _size)
            {
                _items[_count++] = value;
            }

        }

        public void Remove(T item)
        {
            int index = _count;

            for (int i = 0; i < _count; i++)
            {
                if (_items[i].Equals(item))
                {
                    RemoveAt(i);
                    break;
                }

            }

        }

        public void RemoveAt(int index)
        {
            try
            {

                for (int i = index; i < _count; i++)
                {
                    if (i == _count - 1)
                    {
                        _items[i] = default;
                    }
                    else
                    {
                        _items[i] = _items[i + 1];
                    }
                }
            }
            catch (IndexOutOfRangeException)
            {

                throw;
            }
            _count--;
        }

        private T[] Expander(T[] sourceData)
        {   // Expander Cycle Combustion Engine LoX/Methane

            // count old T and 2X the size create =>

            T[] destinationData = new T[_size * 2]; //Creates new array
            destinationData = Copy(sourceData, _size, destinationData, _size * 2, _size); //copies old array to new
            _size = (_size * 2); // doubles capacity

            return destinationData; //return
        }
       
        private T[] Copy(T[] sourceData, int sourceIndex, T[] destinationData, int destinationIndex, int length)
        {
            T[] transferData = new T[length];
            try
            {
                for (int i = 0; i < length; i++)
                {
                    transferData[i] = sourceData[i];
                }
                for (int i = 0; i < length; i++)
                {
                    destinationData[i] = transferData[i];
                }

            }
            catch (IndexOutOfRangeException)
            {

                throw;
            }

            return destinationData;
            // takes in array and copies to other arrays

        }
                
        public void Sort()
        {   // Once Called it passes the appropriate arguments into the BubbleSort
            // Later versions will choose sort algorithms based on size

            _items = BubbleSort(_items, _size);
        }

        private T[] BubbleSort(T[] sourceData, int length)
        {
            // 
            length = _count;
            
            Comparer<T> comparer = Comparer<T>.Default;
            for (int i = (length - 1); i >= 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (comparer.Compare(sourceData[j - 1], sourceData[j]) > 0)
                    {
                        var temp = sourceData[j - 1];
                        sourceData[j - 1] = sourceData[j];
                        sourceData[j] = temp;
                    }
                }
            }
            return sourceData;
        }


        public override string ToString()
        {
            string buildString = "";
            foreach (var item in _items)
            {
                buildString += item.ToString(); 
            }

            return buildString;
        }


    }
}
