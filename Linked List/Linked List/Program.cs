using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            list<int> a = new list<int>();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            a.Add(4);
            a.delete(3);
            a.delete(2);
            a.display();
           //Console.WriteLine(a.Findindex(2));
            Console.ReadKey();
        }

    }

    





}
