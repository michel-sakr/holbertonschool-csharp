﻿using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 98; i++)
            {
                string hexval = i.ToString("x");
                Console.WriteLine(i + " = " + "0x" + hexval);
            }
        }
    }
}
