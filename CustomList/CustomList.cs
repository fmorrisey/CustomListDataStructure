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
        
        private T[] Copy(T[] oldItems, T[] newItems)
        {
            T[] transferItem = new T[_capacity];
            
            for (int i = 0; i < (_capacity / 2); i++)
            {
                transferItem[i] = oldItems[i];
            }
            for (int i = 0; i < _capacity; i++)
            {
                newItems[i] = transferItem[i];
            }

            // takes in array and copies to other arrays
            
            return newItems;
        }

        
        
    }
}
