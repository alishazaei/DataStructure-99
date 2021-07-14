using System;
using System.Collections.Generic;
using System.Text;

namespace hash_table
{
    class list
    {
        Node Head;
        Node Lastnode;
        int Count ;
        public list()
        {
            Count = 0; 
          
        }
      
        public void Add(double key)
        {
          
            if (Count == 0)
            {
                Head = new Node(key, null, null);
                Lastnode = Head;
                Count++;
                return; 

            }
            Node newnode = new Node(key, Lastnode, null);
            Lastnode.before = newnode;
            Lastnode = newnode;
            Count++; 

        }
        public void Remove(double key)
        {
            Node current = Head;
            int i = 0;
            while (current != null)
            {
                if (current.key == key)
                {
                    if (i == 0)
                    {
                        Head = Head.before;
                        Count--;
                        return;
                    }
                       
                    if (i == Count)
                    {
                        current.next.before = null;
                        Count--;
                        return;
                    }
                   
             
                        current.next.before = current.before;
                        current.before.next = current.next;
                   
                
                    Count--;
                }
                i++;
                current = current.before;
            }
           
        }


        public int Search(double key)
        {
            Node current = Head;
            int i = 0;
            while ( current != null)
            {
                if (current.key == key)
                    return i; 
             i++;
                current = current.before;
            }
            return -1; 
        }
        
    }
}
