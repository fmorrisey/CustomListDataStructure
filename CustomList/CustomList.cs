using System;

namespace CustomListProj
{
    public class CustomList<T>
    {
        // _Private Member Variables
        // the _prefix is for private 
        private T[] _items;
        private int _count; //_size
        private int _size;
        private int _nextIndex = 0;

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

        private T[] Copy(T[] sourceData, T[] destinationData) //called in exapander add
        {
            // takes in array and copies to other arrays
            T[] transferData = new T[_size];

            try
            {
                for (int i = 0; i < (_size / 2); i++)
                {
                    transferData[i] = sourceData[i];
                }
                for (int i = 0; i < _size; i++)
                {
                    destinationData[i] = transferData[i];
                }
            }
            catch (IndexOutOfRangeException)
            {

                throw;
            }

            return destinationData;
        }




        public void Sort(T[] sourceData, int length)
        {
            // What Sort of list are we talking about?
            length = _size;

            for (int i = 0; i <= length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    /*if (sourceData[i] > sourceData[j]) //Int Dependant not compatable with T
                    {
                        var temp = _items[i];
                        _items[i] = _items[j];
                        _items[j] = temp;
                    }*/
                }
            }
        }

    }
}
