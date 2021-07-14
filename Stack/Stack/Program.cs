using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleStack stack = new DoubleStack(6);
            stack.Push1("1");
            stack.Push1("2");
            stack.Push1("3");
            stack.Push1("4");
            stack.Push2("5");
            stack.Push2("6");
            stack.Push2("7");
            stack.Push2("8");
            Console.WriteLine(stack.Pop2());
            stack.Push2("9");
            Console.WriteLine(stack.Pop2());
            Console.WriteLine(stack.Pop1());
            Console.WriteLine(stack.Pop1());
            Console.WriteLine(stack.Pop2());
            Console.WriteLine(stack.Pop2());
        }
    }
}
