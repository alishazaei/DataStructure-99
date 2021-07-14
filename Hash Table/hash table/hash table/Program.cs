using System;

namespace hash_table
{
    class Program
    {
        static void Main(string[] args)
        {
            // chaining solution 
            Console.WriteLine("Chaining :");
            Chaining sample = new Chaining();
            sample.Add(10);
            sample.Add(20);
            sample.Add(30);
            sample.Add(40);
            sample.Add(11);
            sample.Add(17);
            sample.Add(21);
            sample.Add(25);
            sample.Add(23);
            sample.Remove(30);
            sample.Remove(20);
            Console.WriteLine(sample.Search(40));
            // Linear probing solution 
            Console.WriteLine("Linear probing :");
            LinearProbing L = new LinearProbing();
            L.Add(10);
            L.Add(12);
            L.Add(14);
            L.Add(13);
            L.Add(11);
            L.Add(15);
            L.Add(28);
            L.Delete(6);
            L.Add(3);
            Console.WriteLine(L.Search(3));
            // Double probing solution 
            Console.WriteLine("Double probing");
            DoubleProbing D = new DoubleProbing();
            D.Add(79);
            D.Add(69);
            D.Add(98);
            D.Add(72);
            D.Add(80);
            D.Add(50);
            D.Add(14);
            D.Delete(1);
            Console.WriteLine(D.Search(14));


        }
    }
}
