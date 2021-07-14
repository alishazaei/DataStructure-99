using System;
using System.Collections.Generic;
using System.Text;

namespace hash_table
{
    class Chaining
    {
        list [] arr = new list[5];
       
        public Chaining()
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] = new list();
      
        }
        public void Add(double key)
        {
            arr[h(key)].Add(key);
        }
        public void Remove(double key)
        {
            arr[h(key)].Remove(key);
        }
        public int Search(double key) //returns the index 
        {
           return arr[h(key)].Search(key);
        }

        public  int h(double k)
        {
            return (int)(k % arr.Length);
        }

    }
}
