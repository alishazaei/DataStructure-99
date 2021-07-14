using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class list <T>
    {
        Node<T> head;
        Node <T>  lastnode;
        public list()
        {
            head = new  Node<T>();
            lastnode = head; // node ghabli

        }

        public void Add(T item) 
        {
            Node<T> newnode = new Node<T>()
            {
                data = item,
            };
            lastnode.next = newnode;
            newnode.previous = lastnode;
            lastnode = newnode; 

        }

        public void display()
        {
            Node<T> sample = head.next;
            while (true)
            {
                Console.Write(sample.data + " ,");
                if (sample.next == null)
                    break;

                sample = sample.next;
            }

            Console.WriteLine();

        }

        public void insert(int index , T item )
        {
           Node<T> newnode = new Node<T>()
            {
                data = item,
            };
            Node<T> currnode = head.next;
            for (int i = 0; i < index; i++)
            {
                currnode = currnode.next;
            }
            newnode.previous = currnode;
            newnode.next = currnode.next;
            currnode.next.previous = newnode;
            currnode.next = newnode;

        }
        public int Count()
        {
            Node<T> currnode = head;
            int count = 0;
            while (currnode.next != null)
            {

                currnode = currnode.next;
                count++;
            }

            return count;

        }

        public void delete(int index)
        {
            Node<T> currnode = head.next;
            int i;
            if (index == 0)
                head = currnode;
            else if (index == Count()-1)
            {
                lastnode.previous.next = null;
            }
            else
            {
                for (i = 1; i <= index && currnode.next!=null; i++)
                {
                    currnode = currnode.next;
                }
                if (i-1!=index && currnode.next == null)
                {

                }
                else
                {
                    currnode.previous.next = currnode.next;
                    currnode.next.previous = currnode.previous;
                }
            }

        }

        public void delval(T item)
        {

            Node<T> currnode = head.next;
            int i;
            
            for (i = 0; !currnode.data.Equals(item) && currnode.next != null  ; i++)
            {
                currnode = currnode.next;
            }
            if (!currnode.data.Equals(item))
            {
            }
            else 
            {
                currnode.previous.next = currnode.next;
                currnode.next.previous = currnode.previous;
            
            }

        }

        public int Findindex(T item) 
        {
            int index = 0 ;
            Node<T> currnode = head.next;

            for (index = 0; !currnode.data.Equals(item) && currnode.next != null;  index ++ )
            { 
                currnode = currnode.next;
            }
            if (!currnode.data.Equals(item))
            {
                return -1; 
            }
            else
            {
                return index; 
            }

        }






    }



}
