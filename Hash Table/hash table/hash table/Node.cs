using System;
using System.Collections.Generic;
using System.Text;

namespace hash_table
{
    class Node
    {
        public double key;
        public Node next;
        public Node before;
        public Node(double key , Node next , Node before )
        {
            this.key = key;
            this.next = next;
            this.before = before;
        }

  
        
    }
}
