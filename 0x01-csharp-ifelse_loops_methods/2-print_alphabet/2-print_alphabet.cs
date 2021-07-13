using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            for (int i = 0; i < 26; i++)
            {
                Console.Write(letter++);
            }
        }
    }
}
