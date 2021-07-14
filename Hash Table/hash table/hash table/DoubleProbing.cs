using System;
using System.Collections.Generic;
using System.Text;

namespace hash_table
{
    class DoubleProbing
    {
        public DoubleProbing()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new element();
                arr[i].flag = status.Null;
            }


        }

        element[] arr = new element[13];
        public void Add(double key)
        {
            int index = h(key);
            if (index != -1)
            {
                arr[index].key = key;
                arr[index].flag = status.normal;
            }
            else
                Console.WriteLine("No Space");
        }
        public int Search(double key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int m = (((int)key % arr.Length) + i * (1+ ((int)key %( arr.Length - 2)))) % (arr.Length);

                if (arr[m].key == key)
                    return m;
                if (arr[m].flag == status.Null)
                    return -1;


            }
            return -1;


        }
        public void Delete(int index) //Get the index
        {
            try
            {
                if (arr[index].flag != status.Null)
                    arr[index].flag = status.deleted;
            }
            catch(Exception e)
            {
                Console.WriteLine("Error : " + e);
            }
 
        }
        public int h(double k)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int m = (((int)k % arr.Length) + i * (1 + ((int)k % (arr.Length - 2)))) % (arr.Length);

                if (arr[m].flag == status.Null || arr[m].flag == status.deleted)
                {
                    return m;
                }



            }
            return -1;

        }


    }
}
