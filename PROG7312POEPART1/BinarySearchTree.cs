using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312POEPART1
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        private Node<T> root;

        public void Insert(T item)
        {
            root = InsertRecursive(root, item);
        }

        private Node<T> InsertRecursive(Node<T> node, T item)
        {
            if (node == null)
                return new Node<T>(item);

            if (item.CompareTo(node.Value) < 0)
                node.Left = InsertRecursive(node.Left, item);
            else if (item.CompareTo(node.Value) > 0)
                node.Right = InsertRecursive(node.Right, item);

            return node;
        }

        public T Find(string itemString)
        {
            return FindRecursive(root, itemString);
        }

        private T FindRecursive(Node<T> node, string itemString)
        {
            if (node == null)
                return default(T);

            // Assuming T (ServiceRequest) has a method or property to get its string representation
            string nodeString = node.Value.ToString();

            int comparison = string.Compare(itemString, nodeString, StringComparison.OrdinalIgnoreCase);

            if (comparison == 0)
                return node.Value;
            if (comparison < 0)
                return FindRecursive(node.Left, itemString);
            else
                return FindRecursive(node.Right, itemString);
        }

        private T FindRecursive(Node<T> node, Func<T, bool> predicate)
        {
            if (node == null)
                return default(T);

            if (predicate(node.Value))
                return node.Value;

            T leftResult = FindRecursive(node.Left, predicate);
            if (!EqualityComparer<T>.Default.Equals(leftResult, default(T)))
                return leftResult;

            return FindRecursive(node.Right, predicate);
        }

        public T Find(Func<T, bool> predicate)
        {
            return FindRecursive(root, predicate);
        }
    }   


    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
