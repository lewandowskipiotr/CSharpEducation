using System;
using System.Collections.Generic;
using System.Text;

namespace AVLTreeProgram
{
    public class Node
    {
        public int data;
        public Node LeftChild;
        public Node RightChild;
        public Node(int value)
        {
            data = value;
        }
    }
}
