using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeLib
{
    public interface ITraverse<KeyType, ValueType>
    {
        void ProcessNode(KeyType key, ValueType payload);
    }
}
