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

        public int Count 
        {
            get
            {
                return count;
            }
            
        } 
        public int Capacity 
        { 

            get => capacity; 
            
        }

        public T this[int i]                      // set this to an argument out of range exception, because you are providing an ARGUMENT to the array
        {                                           // vs an index out of range, where we cant even find the index
            get
            {
                if (i < 0 || i >= count)
                {
                    throw new IndexOutOfRangeException($"Your selection is out or range.");
                }
                
                return _items[i];
            }
            set
            {
                if (i < 0 || i >= count)
                {
                    throw new IndexOutOfRangeException($"Your selection is out or range.");
                }
                _items[i] = value;
            }
        }

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

        public bool Remove(T itemToRemove)  // DO NOT LOWER CAPACITY
        {
            for (int i = 0; i < count; i++)
            {
                if (_items[i].Equals(itemToRemove))
                {
                    // for loops
                    for (int j = i; j < count - 1; j++)  //basing off the parent loop
                    {
                        _items[j] = _items[j + 1];
                    }
                    T[] temp_Array = new T[capacity]; //self note: this is pretty much the ADD METHOD, the "detour"
                    for (int j = 0; j < count -1; j++)  // chose to keep this as j because it doesnt exist outside of the scope. you can call it whatever you want 
                    {
                        temp_Array[j] = _items[j];
                    }
                    _items = new T[capacity];
                    for (int k = 0; k < count; k++)
                    {
                        _items[k] = temp_Array[k];
                    }
                    count--;
                    return true;
                }
            }
            return false;
        }

       
    }
}
