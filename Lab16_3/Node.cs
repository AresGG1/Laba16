
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Net.Mail;
using System.Xml.Schema;

namespace Lab16_3
{

    public class Del<T> where T:IComparable
    {
        public static Node<T> DeleteNode(Node<T> root, T value)
        {
            if (value.CompareTo(root.value) < 0)
                root.left = DeleteNode(root.left, value);
            else if (value.CompareTo(root.value) > 0)
                root.right = DeleteNode(root.right, value);
            else {
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;
                root.value = root.MinValue(root.right).value;
                root.right = DeleteNode(root.right, root.value);
            }
            return root;
        }

        public static void DeleteRoot(Node<T> root)
        {
            var del = root.Successor();
            DeleteNode(root, del.value);
            root.value = del.value;
        }
    }
    
    public class Node<T> where T:IComparable
    {
        public Node<T> left = null;
        public Node<T> right = null;
        public Node<T> parent = null;
        public T value;

        public Node(T value, Node<T> parent = null)
        {
            this.value = value;
            this.parent = parent;
        }

        public Node<T> Successor()
        {
            if (this.right != null)
                return this.MinValue(this.right);
            return this?.left;
        }
        
        public void AddElem(T value)
        {
            if (value.CompareTo(this.value) <= 0)
            {
                if(this.left != null)
                    this.left.AddElem(value);
                else
                {
                    this.left = new Node<T>(value, this);
                    return;
                }
            }
            else if (value.CompareTo(this.value) >= 0)
            {
                if (this.right != null)
                {
                    this.right.AddElem(value);
                }
                else
                {
                    this.right = new Node<T>(value, this);
                }
            }
        }

        public void Find(T value)
        {
            if(EqualityComparer<T>.Default.Equals(this.value, value))
                Console.WriteLine($"{this.value.ToString()} is found ");
            else if (value.CompareTo(this.value) <= 0)
            {
                if (this.left != null)
                {
                    this.left.Find(value);
                }
                else
                {
                    Console.WriteLine($"{this.value.ToString()} is not found");
                }
            }
            else if (value.CompareTo(this.value) >= 0)
            {
                if (this.right != null)
                {
                    this.right.Find(value);
                }
                else
                {
                    Console.WriteLine($"{this.value.ToString()} is not found");
                }
            }
        }

        public void PrintTree()
        {
            if (this != null)
            {
                this.left?.PrintTree();
                Console.Write(this.value);
                Console.Write(" ");
                this.right?.PrintTree();
            }
        }

        public Node<T> MinValue(Node<T> root)
        {
            var min = root;
            while (root.left != null)
            {
                root = root.left;
            }
            min = root;
            return min;
        }

    }
}