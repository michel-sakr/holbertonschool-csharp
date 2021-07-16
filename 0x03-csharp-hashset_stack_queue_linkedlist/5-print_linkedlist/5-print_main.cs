using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        LinkedList<int> llist;
        int size;

        size = 1;

        llist = LList.CreatePrint(size);
        Console.WriteLine("-------------");
        Console.WriteLine("Linked List Length: " + llist.Count);
    }
}