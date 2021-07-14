using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{

    class Node 
    {
        public int coeff;
        public int power;
        public Node  next;
        public Node previous;
        public Node (int coeff , int power)
        {
            this.power = power;
            this.coeff = coeff;
        }
        

    }



}
