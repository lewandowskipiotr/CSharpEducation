//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AVLTreeProgram
//{
//    class BinarySearchTree
//    {
//        public Node root;

//        public BinarySearchTree()
//        {
//            root = null;
//        }

//        public BinarySearchTree(int value)
//        {
//            Node newNode = new Node(value);
//            root = newNode;
//        }

//        private void Insert(int value)
//        {
//            root = FindPlaceToInsert(root, value);
//        }

//        protected Node FindPlaceToInsert(Node currentNode, int newData)
//        {
//            if (currentNode == null)
//            {
//                Node newNode = new Node(newData);
//                currentNode = newNode;
//                return currentNode;
//            }

//            if (newData > currentNode.data)
//            {
//                currentNode.RightChild = FindPlaceToInsert(currentNode.RightChild, newData);
//            }
//            else if (newData <= currentNode.data)
//            {
//                currentNode.LeftChild = FindPlaceToInsert(currentNode.LeftChild, newData);
//            }
//            return currentNode;
//        }

//        public virtual void Delete(int value)
//        {
//            root = FindElementToRemove(root, value);
//        }

//        private Node FindElementToRemove(Node currentNode, int valueToDelete)
//        {
//            if (currentNode == null)
//            {
//                return currentNode;
//            }

//            if (valueToDelete < currentNode.data)
//            {
//                currentNode.LeftChild = FindElementToRemove(currentNode.LeftChild, valueToDelete);
//            }
//            else if (valueToDelete > currentNode.data)
//            {
//                currentNode.RightChild = FindElementToRemove(currentNode.RightChild, valueToDelete);
//            }
//            else if (valueToDelete == currentNode.data)
//            {
//                if (currentNode.LeftChild == null)
//                {
//                    return currentNode.RightChild;
//                }
//                else if (currentNode.RightChild == null)
//                {
//                    return currentNode.LeftChild;
//                }
//                currentNode.data = MinValueInSubtree(currentNode.RightChild);
//                currentNode.RightChild = FindElementToRemove(currentNode.RightChild, currentNode.data);
//            }
//            return currentNode;
//        }

//        private int MinValueInSubtree(Node currentNode)
//        {
//            int min = currentNode.data;
//            while (currentNode.LeftChild != null)
//            {
//                min = currentNode.LeftChild.data;
//                currentNode = currentNode.LeftChild;
//            }
//            return min;
//        }

//        public void DisplayTree()
//        {
//            DisplayNodeDataFromNode(root);
//        }

//        private void DisplayNodeDataFromNode(Node startNode)
//        {
//            if (startNode == null)
//            {
//                return;
//            }
//            Console.WriteLine(startNode.data);
//            DisplayNodeDataFromNode(startNode.LeftChild);
//            DisplayNodeDataFromNode(startNode.RightChild);
//        }

//    }
//}
