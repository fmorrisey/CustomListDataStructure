using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomListProj
{   /// <summary>
    /// <para>Summary:
    ///     Creates a wrapper around an array that represents a strongly typed list of objects that can be accessed by index.<para />
    ///     Provides methods to add, remove, remove at, sort, merge, and manipulate lists.</para>
    ///
    /// <br>Type parameters:
    ///   T:
    ///     The type of elements in the list.</br>
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public class CustomList<T> : IEnumerable where T : IComparable
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
        // Additional overload to setSize
        public CustomList(int setSize)
        {
            this._size = setSize;
            _items = new T[_size];
            this._count = 0;

        }
        /// <summary>
        /// <para>Provides a method for adding an item to the end of the list.</para>
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
        /// <para>Note: The first matching value is removed from the list, and will NOT handle duplicates</para>
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
        /// <para>Provides a method for removing an item at a set index specified in the parameter.</para>
        /// 
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
        public override string ToString()
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

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            try
            {
                int newSize = (firstList.Count + secondList.Count); // determines the size for the transferList
                CustomList<T> transferList = new CustomList<T>(newSize);
                if (firstList.Count == 0) { return transferList; }  // Checks for empty lists
                else if (secondList.Count == 0) { return transferList; }
                else
                {
                    for (int i = 0; i < firstList._count; i++)
                    {   // adds data from first list
                        transferList.Add(firstList[i]);
                    }
                    for (int j = 0; j < secondList._count; j++)
                    {   // adds data from the second list
                        transferList.Add(secondList[j]);
                    }
                    // returns the new lists
                    return transferList;
                }
            }
            catch (IndexOutOfRangeException)
            { throw new Exception("Index Out Of Range"); }
        }

        /// <summary>
        /// Merges two lists into a new list that is returned and
        /// the new list size is total the count of both incoming lists.
        /// </summary>
        public CustomList<T> Merge(CustomList<T> firstList, CustomList<T> secondList)
        {   // External Use
            try
            {
                int newSize = (firstList.Count + secondList.Count); // determines the size for the transferList
                CustomList<T> transferList = new CustomList<T>(newSize);
                if (firstList.Count == 0) { return transferList; }  // Checks for empty lists
                else if (secondList.Count == 0) { return transferList; }
                else
                {
                    for (int i = 0; i < firstList._count; i++)
                    {   // adds data from first list
                        transferList.Add(firstList[i]);
                    }
                    for (int j = 0; j < secondList._count; j++)
                    {   // adds data from the second list
                        transferList.Add(secondList[j]);
                    }
                    // returns the new lists
                    return transferList;
                }
            }
            catch (IndexOutOfRangeException)
            { throw new Exception("Index Out Of Range"); }
        }



        private static CustomList<T> MergeList(CustomList<T> firstList, CustomList<T> secondList)
        {   // Internal Use Only // mimics Public Merge
            try
            {
                int newSize = (firstList.Count + secondList.Count);
                CustomList<T> result = new CustomList<T>(newSize);
                if (firstList.Count == 0) { return result; }
                else if (secondList.Count == 0) { return result; }
                else
                {
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
            }
            catch (IndexOutOfRangeException)
            { throw new Exception("Index Out Of Range"); }
        }


        /// <summary>
        /// Merges and Sort two lists into a new list that is returned and
        /// the new list size is total the count of both incoming lists.
        /// </summary>
        public CustomList<T> Zip(CustomList<T> firstList, CustomList<T> secondList)
        {   // External Use
            try
            {
                int newSize = (firstList.Count + secondList.Count); // determines the size for the transferList
                CustomList<T> transferList = new CustomList<T>(newSize);
                if (firstList.Count == 0) { return transferList; }  // Checks for empty lists
                else if (secondList.Count == 0) { return transferList; }
                else
                {
                    for (int i = 0; i < firstList._count; i++)
                    {   // adds data from first list
                        transferList.Add(firstList[i]);
                    }
                    for (int j = 0; j < secondList._count; j++)
                    {   // adds data from the second list
                        transferList.Add(secondList[j]);
                    }
                }
                //Sorts the list then returns
                transferList.Sort();
                return transferList;
            }
            catch (IndexOutOfRangeException)
            { throw new Exception("Index Out Of Range"); }
        }

        /// PUT THE REMOVEDUPLICATE METHOD HERE!!!!! /////

        /// <summary>
        /// Removes duplicates by from two lists using a Minus ( - ) Operator
        /// 
        /// The new list is equal the count of items in the list
        /// </summary>
        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            try
            {
                int newSize = (firstList.Count + secondList.Count); // determines the size for the transferList
                CustomList<T> transferList = new CustomList<T>(newSize);
                if (firstList.Count == 0) { return transferList; }  // Checks for empty lists
                else if (secondList.Count == 0) { return transferList; }
                else
                {
                    for (int i = 0; i < firstList._count; i++)
                    {   // adds data from first list
                        transferList.Add(firstList[i]);
                    }
                    for (int j = 0; j < secondList._count; j++)
                    {   // adds data from the second list
                        transferList.Add(secondList[j]);
                    }
                }

                transferList.Sort();
                return transferList;
            }
            catch (IndexOutOfRangeException)
            { throw new Exception("Index Out Of Range"); }
        }

        static int removeDuplicates(int []arr, int n) 
    { 
          
        // Return, if array is empty 
        // or contains a single element 
        if (n == 0 || n == 1) 
            return n; 
      
        int []temp = new int[n]; 
          
        // Start traversing elements 
        int j = 0; 
          
        for (int i = 0; i < n - 1; i++) 
          
            // If current element is not equal 
            // to next element then store that 
            // current element 
            if (arr[i] != arr[i+1]) 
                temp[j++] = arr[i]; 
          
        // Store the last element as 
        // whether it is unique or  
        // repeated, it hasn't 
        // stored previously 
        temp[j++] = arr[n-1];  
          
        // Modify original array 
        for (int i = 0; i < j; i++) 
            arr[i] = temp[i]; 
      
        return j; 
    } 



    }
}
