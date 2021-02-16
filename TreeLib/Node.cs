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

        //isRed is implemented as a default (optional) parameter
        public Node(KeyType key, ValueType payload, bool isRed = false)
        {
            Key = key;
            Payload = payload;
            RightChild = null;
            LeftChild = null;
            isRed = true;
        }

        public static int Height(INode<KeyType, ValueType> root)
        {
            int height = -1;
            if (root != null)
            {
                height = 1 + Math.Max(Node<KeyType, ValueType>.Height(root.LeftChild), Node<KeyType, ValueType>.Height(root.RightChild));
            }
                //Return Height of the tree
            return height;
        }

        public static void PreOrderTraversal(INode<KeyType, ValueType> root,
            ITraverse<KeyType, ValueType> traverser)
        {
            if (root != null)
            {
                traverser.ProcessNode(root.Key, root.Payload);//Process Node
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
            if (root != null)
            {   
                builder.Append(root.Key.ToString()); //Append
                if (root.LeftChild != null || root.RightChild != null)
                {

                    builder.Append(" (");
                    ToString(root.LeftChild, builder);
                    builder.Append(") (");
                    ToString(root.RightChild, builder);
                    builder.Append(")");
                }   
            }
            if (builder.Length == 0)
            {
                builder.Append("()");
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
              
            }
        }

        public static INode<KeyType, ValueType> RotateLeft(INode<KeyType, ValueType> root)
        {
            INode<KeyType,ValueType> newRoot = root.RightChild;
            INode<KeyType, ValueType> newNode = root.RightChild.LeftChild; 
            newRoot.LeftChild = root; // update new root
            root.RightChild = newNode;
            return newRoot;
        }

        public static INode<KeyType, ValueType> RotateRight(INode<KeyType, ValueType> root)
        {
            INode<KeyType, ValueType> theRoot = root.LeftChild;
            INode<KeyType, ValueType> updNode = root.LeftChild.RightChild;
            theRoot.RightChild = root; // update new root 
            root.LeftChild = updNode;
            return theRoot;
        }

        public static INode<KeyType, ValueType>
            InsertAtRoot(INode<KeyType, ValueType> root, KeyType key, ValueType value)
        {

            if (root != null)
            { 
                int comparison = key.CompareTo(root.Key); // Comparing keys
                if (comparison < 0)
                {
                    root.LeftChild = InsertAtRoot(root.LeftChild, key, value);
                    root = RotateRight(root);//rotateR
                }
                else
                {
                    root.RightChild = InsertAtRoot(root.RightChild, key, value);
                    root = RotateLeft(root);//RotateL
                }
            }
            else
            {
                root = new Node<KeyType, ValueType>(key, value);
            }
            return root;
        }


        public static void InOrderTraversal(INode<KeyType, ValueType> root,
            ITraverse<KeyType, ValueType> traverser)
        {
          
            if (root.LeftChild != null)
            {
                InOrderTraversal(root.LeftChild, traverser);
            }
            //Process Node
            traverser.ProcessNode(root.Key, root.Payload);
            
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
