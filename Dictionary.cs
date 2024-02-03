using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary<Key, Value>
    {
        Key[] keys;
        Value[] values;
        public Dictionary()
        {
            keys = new Key[0];
            values = new Value[0];
        }

        public void Add(Key id, Value name)
        {
            Key[] tempKey = keys;
            Value[] tempValue = values;

            keys = new Key[keys.Length + 1];
            values = new Value[values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];
                values[i] = tempValue[i];
            }
            keys[keys.Length - 1] = id;
            values[values.Length - 1] = name;
        }

        public int Count
        {
            get { return values.Length; }
        }

    }
}