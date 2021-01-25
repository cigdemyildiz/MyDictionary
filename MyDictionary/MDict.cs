using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MDict <T,Y>
    {
        T[] key;
        T[] tempKey;
        Y[] value;
        Y[] tempValue;
        public MDict()
        {

            key = new T[0];
            value = new Y[0];
        }
        public void Add(T item1, Y item2)
        {
            tempKey = key;
            tempValue = value;

            key = new T[key.Length + 1];
            value = new Y[value.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                key[i] = tempKey[i];
                value[i] = tempValue[i];
            }
            key[key.Length - 1] = item1;
            value[value.Length - 1] = item2;

        }
        
        public void Print()
        {
            for (int i = 0; i < key.Length; i++)
            {
                Console.WriteLine(key[i]+ " " + value[i]);
            }
        }

        public int Count
        {
            get { return key.Length;  }
        }
    }
}
