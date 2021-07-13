using System;

namespace _8_print_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;

            Number.PrintLastDigit(98);
            Number.PrintLastDigit(0);
            r = Number.PrintLastDigit(-1024);
            Console.WriteLine(r);
        }
    }

    class Number
    {
        public static int PrintLastDigit(int number)
        {
            return number % 10;
        }
    }
}
