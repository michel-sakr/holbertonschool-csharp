using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter = 'a';
            for (int i = 0; i < 26; i++)
            {
                if (!letter.Equals('q') && !letter.Equals('e'))
                    Console.Write(letter);
                letter++;
            }
        }
    }
}
