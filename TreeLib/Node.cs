using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    public class Node<KeyType, ValueType> : INode<KeyType, ValueType> where
        KeyType : IComparable<KeyType>
    {
        public KeyType Key { get; set; }
        public ValueType Payload { get; set; }

        public INode<KeyType, ValueType> LeftChild { get; set; }
        public INode<KeyType, ValueType> RightChild { get; set; }

        public Node(KeyType key, ValueType payload)
        {
            Key = key;
            Payload = payload;
        }

        public static int Height(INode<KeyType, ValueType> root)
        {
            if (root == null)
                return -1;
            return 1 + Math.Max(Height(root.LeftChild), Height(root.RightChild));
        }

        public static void PreOrderTraversal(INode<KeyType, ValueType> root,
            ITraverse<KeyType, ValueType> traverser)
        {
            if (root != null)
            {
                traverser.ProcessNode(root.Key, root.Payload);
                Console.Write(root.LeftChild);
                if (root.LeftChild != null)
                {
                    PostOrderTraversal(root.LeftChild, traverser);
                }
                if (root.RightChild != null)
                {
                    PostOrderTraversal(root.RightChild, traverser);
                }
                
            }
        }

        public static void ToString(INode<KeyType, ValueType> root, StringBuilder builder)
        {
            builder.Append("()");
            if (root != null)
            {
                builder.Insert(1,"g");
            }
            
            
        }

        public static void PostOrderTraversal(INode<KeyType, ValueType> root,
           ITraverse<KeyType, ValueType> traverser)
        {
            if(root != null)
            {
                if (root.LeftChild != null)
                {
                    PostOrderTraversal(root.LeftChild, traverser);
                }
                if (root.RightChild != null)
                {
                    PostOrderTraversal(root.RightChild, traverser);
                }
                traverser.ProcessNode(root.Key, root.Payload);
                Console.Write(root.LeftChild);
            }
        }

        public static INode<KeyType, ValueType> RotateLeft(INode<KeyType, ValueType> root)
        {
            INode<KeyType,ValueType> temp = root.LeftChild;
            root.LeftChild = temp.RightChild;
            temp.RightChild = root;
            return temp;
        }

        public static INode<KeyType, ValueType> RotateRight(INode<KeyType, ValueType> root)
        {
            INode<KeyType, ValueType> temp = root.RightChild;
            root.RightChild = temp.LeftChild;
            temp.LeftChild = root;
            return temp;
        }

        //public static INode<KeyType, ValueType> 
        //    InsertAtRoot(INode<KeyType, ValueType> root, KeyType key, ValueType value)
        //{
        //}


        public static void InOrderTraversal(INode<KeyType, ValueType> root,
            ITraverse<KeyType, ValueType> traverser)
        {
            //Ask Dr Ribler about the use of traverser, if we should process node on the recursive call
            //The FindMaxTraverser constructor. And if we should
            //Anti base case
            //if(root != null)
                
            if (root.LeftChild != null)
            {
                InOrderTraversal(root.LeftChild, traverser);
            }
            //Process Node
            traverser.ProcessNode(root.Key, root.Payload);
            //Line to print below
             //Console.Write(root.Key.ToString());
            if (root.RightChild != null)
            {
                InOrderTraversal(root.RightChild, traverser);
            }
            
        }

        // Insert assumes that we already have a root node that we
        // are going to add a new node to.
        public static void Insert(INode<KeyType, ValueType> root,
                KeyType key, ValueType payload)
        {
            // Base case is the subtree we want to insert into is empty
            //    Add a new node to that root.
            // Base case is the keys match
            //    Change the payload
            // Otherwise
            //   Recursively call the insert function on the left or right subtree
            //   depending on whether the key is < or > the root key.

            // CompareTo returns 0 if ==, negative value if key<root.Key and positive value
            // otherwise
            int comparison = key.CompareTo(root.Key);

            if (comparison < 0)
            {
                // Need to insert into the left subtree

                if (root.LeftChild == null)
                {
                    // Base case - just insert new node here
                    root.LeftChild = new Node<KeyType, ValueType>(key, payload);
                }
                else
                {
                    // Recursively call the function on the left subtree
                    Insert(root.LeftChild, key, payload);
                }
            }
            else
            {
                if (comparison > 0)
                {
                    // Need to insert into the right subtree

                    if (root.RightChild == null)
                    {
                        // Base case - just insert new node here
                        root.RightChild = new Node<KeyType, ValueType>(key, payload);
                    }
                    else
                    {
                        // Recursively call the function on the right subtree
                        Insert(root.RightChild, key, payload);
                    }
                }
                else
                {
                    // The root key and the key being inserted are ==
                    root.Payload = payload;
                }
            }
        }
    }
}
