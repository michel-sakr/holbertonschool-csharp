using System;

namespace _10_print_line
{
    class Program
    {
        static void Main(string[] args)
        {
            Line.PrintLine(3);
            Line.PrintLine(0);
            Line.PrintLine(12);
            Line.PrintLine(-98);
        }
    }

    class Line
    {
        public static void PrintLine(int length)
        {
            if (length <= 0)
            {
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();

        }
    }
}
