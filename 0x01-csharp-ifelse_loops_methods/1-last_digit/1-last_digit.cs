﻿using System;

namespace _1_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndm = new Random();
            int number = rndm.Next(-10000, 10000);
            int last_digit = number % 10;
            Console.Write("The last digit of " + number + " is ");
            if (last_digit > 5)
            {
                Console.WriteLine(last_digit + " and is greater than 5");
            }
            else if (last_digit == 0)
            {
                Console.WriteLine(last_digit + " and is 0");
            }
            else if (last_digit < 6 && last_digit != 0)
            {
                Console.WriteLine(last_digit + " and is less than 6 and not 0");
            }
        }
    }
}
