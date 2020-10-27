using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CustomListProj
{
    public class CustomList<T>
    {
        // _Private Member Variables
        // the _prefix is for private 
        private T[] _items;
        private int _count; //_size
        private int _capacity;
        private int _nextIndex = 0;

        // Property
        public int Count { get { return _count; } }
        public int Capacity { 
            get { return _capacity; } 
            set { _capacity = value; } 
        }
        
        public T this[int i] // Indexer 
        {
            get
            {
                if (i >= 0)
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
            
            this._capacity = 4;
            _items = new T[_capacity];

            this._count = 0;
            
        }
        
        public void Add(T value)
        {
            /// take in single item
            /// Add an item the preExsisting array
            /// check array size
            // count equals capacity
            // array is full
            // if full call a copy expands array
            //if not full add to existing array
            //increment count and add to open slot
            if (_nextIndex == _capacity)
            {
                _items = Expander(_items);
                _items[_nextIndex++] = value;

            } else if (_nextIndex >= _count)
            {
                _items[_nextIndex++] = value;
            }
            _count++;
        }

        public void Remove(T item)
        {
            int index = _count;

            if (index >= 0)
            {
                RemoveAt(index);
                
            }
                        
        }
        
        public void RemoveAt(int index)
        {
            if (index > _capacity)
            {
                throw new ArgumentOutOfRangeException();
            }

            else if (index <= _capacity)
            {
                Copy(_items, index + 1, _items, index, _capacity - index);
            }
        }


        private T[] Expander(T[] oldItems)
        {   // Expander Cycle Combustion Engine LoX/Methane

            // count old T and 2X the size create =>
            // create a new tempT[] that 2x old T[]

            _capacity = (_capacity * 2); // Capacity x 2
            T[] newItems = new T[_capacity];
            
            // copy old T to new EVEN BIGGER T[]
            // Loop to iterate and copy old T[] to new T[]
            // add across
            // Copy Method
            Copy(oldItems, newItems);

            return newItems;
        }
        
        

        private T[] Copy(T[] oldItems, T[] newItems) //called in exapander add
        {
            T[] transferItem = new T[_capacity];
            try
            {
                for (int i = 0; i < (_capacity / 2); i++)
                {
                    transferItem[i] = oldItems[i];
                }
                for (int i = 0; i < _capacity; i++)
                {
                    newItems[i] = transferItem[i];
                }
            }
            catch (IndexOutOfRangeException)
            {

                throw;
            }    
            

            // takes in array and copies to other arrays
            
            return newItems;
        }

        private bool Copy(T[] oldItems, int oldIndex, T[] newItems , int newIndex, int length)
        {
            T[] transferItem = new T[length];
            try
            {
                for (int i = 0; i < length ; i++)
                {
                    transferItem[i] = oldItems[i];
                }
                for (int i = 0; i < length; i++)
                {
                    newItems[i] = transferItem[i];
                }
                return true;
            }
            catch (IndexOutOfRangeException)
            {

                throw;
            }


            // takes in array and copies to other arrays

            
        }

        /*
        public void Copy(int[] oldArray, int[] newArray, int length)
        {
            // takes in array and copies to other arrays
            int[] transferItem = new int[length];
            
            try
            {
                for (int i = 0; i < length; i++)
                {
                    transferItem[i] = oldArray[i];
                }
                for (int i = 0; i < _capacity; i++)
                {
                    newArray[i] = transferItem[i];
                }
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
            
        }
        */


    }
}
