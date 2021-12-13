using System;

namespace AVLTreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            AvlTree tree = new AvlTree();

            tree.Insert(10);
            tree.Insert(20);
            tree.Insert(30);
            tree.Insert(40);
            tree.Insert(50);
            tree.Insert(25);
            tree.DisplayTree();

            Console.ReadKey();
        }
    }
}
