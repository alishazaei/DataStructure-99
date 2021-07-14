using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            list a = new list(2 , 3 );
            a.Add(1 , 2);
            a.Add(3 , 0 );
           
            list b = new list(2, 6);
            b.Add(4, 3);
            b.Add(4, 0);

           
            a.sub(a, b);
            a.minus(a, b);
            Console.ReadKey();
        }

    }

    





}
