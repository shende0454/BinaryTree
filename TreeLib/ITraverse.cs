using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    public interface ITraverse<KeyType, ValueType>
    {// call at every node visit so we can do as we want 
        void ProcessNode(KeyType key, ValueType payload);
    }
}
