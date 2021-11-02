using System;
using System.Collections.Generic;

namespace PepeTask1_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            MyLinkedList list = new MyLinkedList(1);
            list.AddNode(2);
            list.AddNode(3);
            list.AddNode(4);
            //list.Root.Next.Next.Next = list.Root.Next.Next;

            // list.ShowList(list.Root);

            Console.WriteLine("Floyd method:");
            list.ChecklooopFloyd();

            Console.WriteLine("Flags method:");
            list.CheckloopFlags();

            Console.ReadKey();
        }
    }
}
