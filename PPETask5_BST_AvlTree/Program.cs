using System;

namespace AVLTreeProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            AvlTree tree = new AvlTree();

            tree.Insert(12);
            tree.Insert(24);
            tree.Insert(32);
            tree.Insert(48);
            tree.Insert(78);
            tree.Insert(25);
            tree.DisplayTree();

            Console.ReadKey();
        }
    }
}
