using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp
{
    public class BinaryTree<T> : IEnumerable<T> where T : IComparable<T>
    {
        private class Node
        {
            public T Data;
            public Node Left;
            public Node Right;

            public Node(T data)
            {
                Data = data;
                Left = null;
                Right = null;
            }
        }

        private Node root;

        // Метод додавання нового вузла до дерева
        public void Insert(T value)
        {
            if (root == null)
            {
                root = new Node(value);
            }
            else
            {
                InsertRecursive(root, value);
            }
        }

        private void InsertRecursive(Node node, T value)
        {
            int comparison = value.CompareTo(node.Data);

            if (comparison < 0)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    InsertRecursive(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    InsertRecursive(node.Right, value);
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return PreOrderTraversal(root).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        // Прямий обхід дерева (preorder)
        private List<T> PreOrderTraversal(Node node)
        {
            List<T> result = new List<T>();

            if (node != null)
            {
                // Поточний вузол
                result.Add(node.Data);

                // Ліве піддерево
                List<T> leftList = PreOrderTraversal(node.Left);
                for (int i = 0; i < leftList.Count; i++)
                {
                    result.Add(leftList[i]);
                }

                // Праве піддерево
                List<T> rightList = PreOrderTraversal(node.Right);
                for (int i = 0; i < rightList.Count; i++)
                {
                    result.Add(rightList[i]);
                }
            }

            return result;
        }
    }
}
