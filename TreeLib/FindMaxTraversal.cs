using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    public class FindMaxTraversal<KeyType, ValueType> : ITraverse<KeyType, ValueType>
        where KeyType : IComparable<KeyType> 
        where ValueType : IComparable<ValueType>
    {
        public KeyType MaxKey { get; set; }
        public ValueType MaxPayload { get; set; }
        public List<KeyType> KeyList { get; set; } = new List<KeyType>();

        public FindMaxTraversal(KeyType initialMaxKey, ValueType initialMaxValue)
        {
            MaxKey = initialMaxKey;
            MaxPayload = initialMaxValue;
        }

        // This function should get called on each node.
        // Write it so that it:
        //     Updates MaxKey if this key is larger
        //     Updates MaxPayload if payload is larger
        //     Adds the key to the KeyList
        public void ProcessNode(KeyType key, ValueType payload)
        {
            
            if (key.CompareTo(MaxKey) == 1)
            {
                MaxKey = key;
            }
            if (payload.CompareTo(MaxPayload) == 1)
            {
                MaxPayload = payload;
            }
            KeyList.Add(key);
        }
    }
}
