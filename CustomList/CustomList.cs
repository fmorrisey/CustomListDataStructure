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
        // Member Variables
        private T[] items;
        private int count;

        private int capcity;

        // Property
        public int Count { get { return count; } }
        public int Capcity { 
            get { return capcity; } 
            set { capcity = value; } 
        }
        
        public T this[int i] // Indexer 
        {
            get
            {
                if (i >= 0 && i < count)
                {
                    return items[i];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set { items[i] = value; }
        }

        public CustomList()
        {
            this.capcity = 4;
        }
        
        public void Add(T item)
        {
            // take in single item
            // Add an item the preExsisting array
            // check array size
            // count equals capacity
            //array is full
            // if full call a copy expands array
            //if not full add to existing array
            //increment count and add to open slot

            
        }

        public T[] Expander(T[] oldItems)
        {
            T[] newItems = new T[count];
            // Capcaity x 2
            // count old T and 2X the size create =>
            // create a new tempT[] that 2x old T[]
            // copy old T to new EVEN BIGGER T[]
            // Loop to iterate and copy old T[] to new T[]
            // add across
            // Copy Method

            return newItems;
        }
        /*
        public T[] Copy(T[], T[])
        {
            // takes in array and coipies to other arrays
            return T[]
        }
        */
    }
}
