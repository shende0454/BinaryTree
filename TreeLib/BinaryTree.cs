using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    public class BinaryTree<KeyType, ValueType>
           where KeyType : IComparable<KeyType>
    {
        INode<KeyType, ValueType> Root;
        
        public int Height()
        {
               return Node<KeyType, ValueType>.Height(Root);    
        }

        public void Insert(KeyType key, ValueType payload)
        {
            if (Root == null)
            {
                Root = new Node<KeyType, ValueType>(key, payload);
            }
            else
            {
                Node<KeyType, ValueType>.Insert(Root, key, payload);
            }
        }

        public void InOrderTraversal(ITraverse<KeyType, ValueType> traverser)
        {
            Node<KeyType, ValueType>.InOrderTraversal(Root, traverser);
        }

        public void PreOrderTraversal(ITraverse<KeyType, ValueType> traverser)
        {
            Node<KeyType, ValueType>.PreOrderTraversal(Root, traverser);
        }

        public void PostOrderTraversal(ITraverse<KeyType, ValueType> traverser)
        {
            Node<KeyType, ValueType>.PostOrderTraversal(Root, traverser);
        }


        //public IEnumerable<KeyType> InOrder()
        //{
        //}

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            //create string builder
            sb.Append("(");
            Node<KeyType, ValueType>.ToString(Root, sb);
            sb.Append(")");
            return sb.ToString();
        }

        public void RotateLeft()
        {
           Root =  Node<KeyType, ValueType>.RotateLeft(Root);
        }

        public void InsertAtRoot(KeyType key, ValueType payload)
        {
            Root = Node<KeyType, ValueType>.InsertAtRoot(Root,key,payload);
        }

        public void RotateRight()
        {
           Root =  Node<KeyType, ValueType>.RotateRight(Root);
        }
    }
}
