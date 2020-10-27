using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    public class CustomList<T>
    {
        // _Private Member Variables
        // the _prefix is for private 
        private T[] _items;
        private int _count;
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
                if (i >= 0 && i < _count)
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
        }
        
        public void Add(T value)
        {
            
                        
            // take in single item
            // Add an item the preExsisting array
            // check array size
            // count equals capacity
            //array is full
            // if full call a copy expands array
            //if not full add to existing array
            //increment count and add to open slot

            if (_nextIndex >= _count)
            {
                _items[_nextIndex++] = value;
            }
                
            
                
            
            
            
        }

        public void Remove(T item)
        {

        }

        private T[] Expander(T[] oldItems)
        {
            T[] newItems = new T[_count];
            // Capacity x 2
            if (_count > 4)
            {

            }
            // count old T and 2X the size create =>
            // create a new tempT[] that 2x old T[]
            // copy old T to new EVEN BIGGER T[]
            // Loop to iterate and copy old T[] to new T[]
            // add across
            // Copy Method
            Copy(oldItems, newItems);

            return newItems;
        }
        
        private T[] Copy(T[] oldItem, T[] newItems)
        {
            newItems = new T[_capacity];
            T[] transferItem = new T[_capacity];

            // takes in array and copies to other arrays
            
            return newItems;
        }

        
        
    }
}
