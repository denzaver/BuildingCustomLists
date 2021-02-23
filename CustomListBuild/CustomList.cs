using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListBuild
{
    public class CustomList<T>
    {
        //member variables
        private T[] _items;  // this is an array "[]"

        private int count;
        private int capacity;
        public int Count {
            get
            {
                return count;
            }
            
        }//Properties slideshow Health/health example
        public int Capacity { get; set; }

        //ctor
        public CustomList()
        {
            count = 0;
            capacity = 4;
            _items = new T[capacity];
        }

        //member methods
        public void Add(T itemToAdd)
        {
            if (count == capacity)
            {
                // create new array
                T[] _items = new T[capacity *= 2];
                // move items over
                for (int i = 0; i < count; i++)
                {
                    
                }
                // new array is _items array
            }
            _items[count] = itemToAdd;
            count++;
        }

    }
}
