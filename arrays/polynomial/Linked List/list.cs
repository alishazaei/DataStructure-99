using System;
using System.Collections.Generic;
using System.Text;

namespace Linked_List
{
    class list 
    {
        Node head;
        Node lastnode;
        public list(int coeff, int power)
        {
        
            head = new  Node(coeff, power ); 
            lastnode = head; // node ghabli

        }

        public void Add(int coeff , int power ) 
        {
            Node newnode = new Node(coeff, power);

            lastnode.next = newnode;
            newnode.previous = lastnode;
            lastnode = newnode; 

        }

       
        public int Count()
        {
            Node currnode = head;
            int count = 0;
            while (currnode != null)
            {

                currnode = currnode.next;
                count++;
            }
            return count;

        }

        public list sub( list a , list b)
        {
            string result = ""; 
            Node currnodeA = a.head;
            Node currnodeB = b.head;
            list c = new list(0,0);
            int count = 0;
            while ( currnodeA!=null && currnodeB != null)
            {
               
                if ( currnodeA.power > currnodeB.power)
                {
                    if (count == 0)
                        c = new list (currnodeA.coeff, currnodeA.power);
                    else
                        c.Add(currnodeA.coeff, currnodeA.power);

                    result += currnodeA.coeff + "X^" + currnodeA.power + " + ";
                    currnodeA = currnodeA.next;
                    count++;

                }
                else if (currnodeA.power < currnodeB.power)
                {
                    if (count == 0)
                        c = new list(currnodeB.coeff, currnodeB.power);
                    else
                        c.Add(currnodeB.coeff, currnodeB.power);


                    result += currnodeB.coeff + "X^" + currnodeB.power + " + ";
                    currnodeB = currnodeB.next;
                    count++;
                }
                else
                {
                    if (count == 0)
                        c = new list(currnodeA.coeff, currnodeA.power);
                    else
                        c.Add(currnodeA.coeff, currnodeA.power);


                    int sum = currnodeA.coeff + currnodeB.coeff;
                    result += sum + "X^" + currnodeA.power + " + ";
                    currnodeA = currnodeA.next;
                    currnodeB = currnodeB.next;
                    count++;
                }
              
                
             
            }
            Console.WriteLine(result.Remove(result.Length - 2));

            return c;


        }


        public list minus(list a, list b)
        {
            string result = "";
            Node currnodeA = a.head;
            Node currnodeB = b.head;
            list c = new list(0, 0);
            int count = 0;
            while (currnodeA != null && currnodeB != null)
            {

                if (currnodeA.power > currnodeB.power)
                {
                    if (count == 0)
                        c = new list(currnodeA.coeff, currnodeA.power);
                    else
                        c.Add(currnodeA.coeff, currnodeA.power);

                    result += currnodeA.coeff + "X^" + currnodeA.power + " + ";
                    currnodeA = currnodeA.next;
                    count++;

                }
                else if (currnodeA.power < currnodeB.power)
                {
                    if (count == 0)
                        c = new list(currnodeB.coeff, currnodeB.power);
                    else
                        c.Add(currnodeB.coeff, currnodeB.power);


                    result += currnodeB.coeff + "X^" + currnodeB.power + " + ";
                    currnodeB = currnodeB.next;
                    count++;
                }
                else
                {
                    if (count == 0)
                        c = new list(currnodeA.coeff, currnodeA.power);
                    else
                        c.Add(currnodeA.coeff, currnodeA.power);


                    int sum = currnodeA.coeff  - currnodeB.coeff;
                    if (sum > 0)
                    result += sum + "X^" + currnodeA.power + " + ";
                    else
                    result += "("+sum + "X^" + currnodeA.power +")"+ " + ";
                    currnodeA = currnodeA.next;
                    currnodeB = currnodeB.next;
                    count++;
                }



            }
            Console.WriteLine(result.Remove(result.Length - 2));

            return c;


        }



    }



}
