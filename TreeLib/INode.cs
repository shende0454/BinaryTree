using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    // KeyType has CompareTo(object thingToCompareTo) defined
    // public interface INode<KeyType, ValueType> where KeyType : IComparable

    // KeyType has CompareTo(KeyType thingToCompareTo) defined.
    public interface INode<KeyType, ValueType> where KeyType : IComparable<KeyType>
    {
        // We want the following properties.
        // myObject.Key invokes get.
        // myObject.Key = something invokes set.
        KeyType Key { get; set; }
        ValueType Payload { get; set; }

        INode<KeyType, ValueType> LeftChild { get; set; }
        INode<KeyType, ValueType> RightChild { get; set; }

    }

}
