using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomListProj
{   /// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
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

        public CustomList(int setSize)
        {
            this._size = setSize;
            _items = new T[_size];
            this._count = 0;
            
        }
        /// <summary>
        /// <para>Provides a method for adding the input item to the end of the list based.</para>
        /// </summary>
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
        /// <summary>
        /// <para>Provides a method for removing a matching value from the list based on the arguments.</para>
        /// <para>Note:</para>
        /// <para>The first matching value is removed from the list, and will handle duplicates</para>
        /// </summary>    
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

        /// <summary>
        /// <para>Provides a method for removing a set item at the index specified in the parameter.</para>
        /// <para>Note:</para>
        /// <para>The first matching value is removed from the list, and will handle duplicates</para>
        /// </summary>
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

        /// <summary>
        /// <para>Provides a method for sorting the list taking in no arguments.</para>
        /// <para>Note:</para>
        /// <para>This list is sorted based on the number of items in the list
        /// using the first letter or character of the item.
        /// Ascending and descending numerals to letters (ignores case)</para>
        /// </summary>                
        public void Sort() 
        {   // Once Called it passes the appropriate arguments into the BubbleSort
            // Later versions will choose sort algorithms based on size
            _items = BubbleSort(_items, _size);
        }

        private T[] BubbleSort(T[] sourceData, int length)
        {
            // Bubble Sort Algorithm that sorts numbers than letters
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

        /// <summary>
        /// <para>Provides a method to convert any data type to a return string.</para>
        /// </summary>
        public override string ToString() // Coverts Data Types to String Values
        {
            string buildString = "";
            foreach (var item in _items)
            {
                buildString += item.ToString(); 
            }

            return buildString;
        }

        /// <summary>
        /// Merges two lists using a Plus ( + ) Operator
        /// 
        /// The new list total count of both incoming lists.
        /// </summary>

        public static CustomList<T> operator +(CustomList<T> one, CustomList<T> two)
        {
            int newSize = (one.Count + two.Count);
            
            CustomList<T> result = new CustomList<T>(newSize);

            for (int i = 0; i < one._count; i++)
            {
                result.Add(one[i]);
            }
            for (int j = 0; j < two._count; j++)
            {
                result.Add(two[j]);
            }

            return result;
        }

        /// <summary>
        /// Merges two lists into a new list that is returned and
        /// the new list size is total the count of both incoming lists.
        /// </summary>
        public CustomList<T> CopyLists(CustomList<T> firstList, CustomList<T> secondList)
        {   
            int newSize = (firstList.Count + secondList.Count);

            CustomList<T> result = new CustomList<T>(newSize);

            for (int i = 0; i < firstList._count; i++)
            {
                result.Add(firstList[i]);
            }
            for (int j = 0; j < secondList._count; j++)
            {
                result.Add(secondList[j]);
            }

            return result;
        }

        /// <summary>
        /// Merges two lists using a Plus ( + ) Operator
        /// 
        /// The new list total count of both incoming lists.
        /// </summary>

        public static CustomList<T> operator -(CustomList<T> one, CustomList<T> two)
        {
            int newSize = (one.Count + two.Count);

            CustomList<T> result = new CustomList<T>(newSize);

            for (int i = 0; i < one._count; i++)
            {
                result.Add(one[i]);
            }
            for (int j = 0; j < two._count; j++)
            {
                result.Add(two[j]);
            }

            return result;
        }

    }
}
