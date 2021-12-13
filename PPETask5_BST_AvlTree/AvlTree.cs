using System;
using System.Collections.Generic;
using System.Text;

namespace AVLTreeProgram
{
    class AvlTree : BinarySearchTree
    {       
        public AvlTree()
        {
            root = null;
        }

        private Node InsertInTheRightPlaceAndBalanceTree(Node nodePointer, Node newNode)
        {
            if (nodePointer == null)
            {
                nodePointer = newNode;
                return nodePointer;
            }
            else if (newNode.data < nodePointer.data)
            {
                nodePointer.LeftChild = InsertToTheRightPlace(nodePointer.LeftChild, newNode.data);
                nodePointer = BalanceTree(nodePointer);
            }
            else if (newNode.data > nodePointer.data)
            {
                nodePointer.RightChild = InsertToTheRightPlace(nodePointer.RightChild, newNode.data);
                nodePointer = BalanceTree(nodePointer);
            }
            return nodePointer;
        }

        public override void Insert(int value)
        {            
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                root = InsertInTheRightPlaceAndBalanceTree(root, new Node(value));
            }
        }

        private int GetHeight(Node current)
        {            
            if (current != null)
            {
                return (1 + Math.Max(GetHeight(current.LeftChild), GetHeight(current.RightChild)));
            }
            return 0;
        }

        private int GetBalanceValue(Node current)
        {
            return GetHeight(current.LeftChild) - GetHeight(current.RightChild);
        }

        private Node BalanceTree(Node nodePointer)
        {
            int balanceValue = GetBalanceValue(nodePointer);

            if (balanceValue > 1)
            {
                if (GetBalanceValue(nodePointer.LeftChild) > 0)
                {
                    nodePointer = RotationLeftLeft(nodePointer);
                }
                else
                {
                    nodePointer = RotationLeftRight(nodePointer);
                }
            }
            else if (balanceValue < -1)
            {
                if (GetBalanceValue(nodePointer.RightChild) > 0)
                {
                    nodePointer = RotationRightLeft(nodePointer);
                }
                else
                {
                    nodePointer = RotationRighRight(nodePointer);
                }
            }
            return nodePointer;
        }

        private Node RotationLeftLeft(Node parent)
        {
            Node temp = parent.LeftChild;
            parent.LeftChild = temp.RightChild;
            temp.RightChild = parent;
            return temp;
        }

        private Node RotationRighRight(Node parent)
        {
            Node temp = parent.RightChild;
            parent.RightChild = temp.LeftChild;
            temp.LeftChild = parent;
            return temp;
        }

        private Node RotationLeftRight(Node parent)
        {
            Node temp = parent.LeftChild;
            parent.LeftChild = RotationRighRight(temp);
            return RotationLeftLeft(parent);
        }

        private Node RotationRightLeft(Node parent)
        {
            Node temp = parent.RightChild;
            parent.RightChild = RotationLeftLeft(temp);
            return RotationRighRight(parent);
        }





    }
}
