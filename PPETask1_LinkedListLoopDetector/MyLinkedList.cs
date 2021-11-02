using System;
using System.Collections.Generic;
using System.Text;

namespace PepeTask1_LinkedList
{
    class MyLinkedList
    {
        public Node Root;

        public MyLinkedList(int value)
        {
            Root = new Node(value);
        }

        // Add node at the end of the list
        public void AddNode(int value)
        {
            Node current = Root;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = new Node(value);
        }

        public Boolean ChecklooopFloyd()
        {
            Node slow = Root;
            Node fast = Root;

            while(slow != null && fast !=null && fast.Next !=null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if(slow == fast)
                {
                    Console.WriteLine("Loop detected");
                    return true;
                }

            }
            Console.WriteLine("No Loops detected");
            return false;
        }

        public Boolean CheckloopFlags()
        {
            Node current = Root;
            while (current != null)
            {   
                if(current.isVisited == true)
                {
                    Console.WriteLine("Loop detected");
                    return true;
                }
                current.isVisited = true;
                current = current.Next;            
            }
            Console.WriteLine("No loops detected");
            return false;
        }

        public bool CheckLoopHash()
        {
            HashSet<Node> hashSet = new HashSet<Node>();
            Node current = Root;
            while (current != null)
            {
                if (hashSet.Contains(current))
                {
                    Console.WriteLine("Loop detected");
                    return true;
                }
                hashSet.Add(current);
                current = current.Next;
            }
            Console.WriteLine("No loops detected");
            return false;
        }


            //public void ShowList(Node nextNode)
            //{
            //    Console.WriteLine(nextNode.Value);
            //    if (nextNode.Next != null)
            //    {
            //        ShowList(nextNode.Next);
            //    }
            //}
    }
}
