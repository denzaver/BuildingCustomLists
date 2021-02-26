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
        public int Capacity { 

            get => capacity; 
            
        }

        public T this[int i]
        {
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

        public void Remove(T itemToRemove)  // DO NOT LOWER CAPACITY
            // 
        {
            //T[] temp_array = new T[capacity]; -- turns out this does nothing to affect the code

            for (int i = 0; i < count; i++)
            {
                if (_items[i].Equals(itemToRemove))
                {
                    do
                    {
                        _items[i] = _items[i + 1]; //SELF NOTE: this replaces the _items[i] with the thet index -->
                                                   // --- the last time it runs, its trying to access an index that ISNT THERE

                        if (_items[i].Equals(count - 1))   // the if statement is attempt say that when you last item in the "count", set it to zero, 
                                                                //since we're already moved/copied over everything to the spot just before                     
                        {               // if/else   count -1,  null
                            i = null;
                        }
                        else
                        {
                            ;
                        }


                        i++; //SELF NOTE: this should move us to the next index
                    }
                    while (i < count);

                    count--; //SELF NOTE: 
                    //temp_array = _items;

                }
            }
            //_items = temp_array;  -- turns out this does nothing to affect the code
        }
    }
}
