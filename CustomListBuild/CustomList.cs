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
        private T[] _items;  //SELF NOTE: this is an array "[]"

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
                T[] New_items = new T[capacity *= 2];//SELF NOTE:this should creaete a new array and double its size?
                // move items over
                for (int i = 0; i < count; i++)
                {
                    New_items[i] = _items[i]; 
                    
                }
                // new array is _items array
                _items = New_items;
            }
            
            _items[count] = itemToAdd; 
            count++;
        }

        public void Remove(T itemToRemove)
        {

        }
    }
}
