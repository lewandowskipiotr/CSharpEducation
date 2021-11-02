using System;
using System.Collections.Generic;
using System.Text;

namespace PepeTask1_LinkedList
{
    class Node
    {
        public Node Next;
        public int Value { get; set; }
        public Boolean isVisited;
        public  Node(int value)
        {
            Value = value;
            Next = null;
        }
        public Node() 
        {
            isVisited = false;
        }

    }
}
