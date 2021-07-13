using System;

namespace _9_add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", Number.Add(1, 2));
            Console.WriteLine("{0}", Number.Add(98, 0));
            Console.WriteLine("{0}", Number.Add(100, -2));
        }
    }

    class Number
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
