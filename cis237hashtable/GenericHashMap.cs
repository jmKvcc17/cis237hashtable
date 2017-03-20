using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237hashtable
{
    class GenericHashMap<TKey, TValue>
    {
        private const int PRIMEVALUE = 97;
        TValue[] theValues;

        public GenericHashMap()
        {
            theValues = new TValue[PRIMEVALUE];
        }

        public TValue Get(TKey key)
        {
            int indexForValues = hashFunction(key);
            return theValues[indexForValues];
        }

        public void Put(TKey key, TValue value)
        {
            int indexForValues = hashFunction(key);
            theValues[indexForValues] = value;
        }

        public override string ToString()
        {
            string returnString = "Key     => Value\n";
            returnString += "------------------------\n";
            for (int i = 0; i < theValues.Length; i++)
            {
                if (theValues[i] != null)
                {
                    returnString += i + " => " + theValues[i] + "\n";
                }
            }
            return returnString;
        }

        public string showArray()
        {
            string returnString = "Key     => Value\n";
            returnString += "------------------------\n";
            for (int i = 0; i < theValues.Length; i++)
            {
                returnString += "[" + i + "] => " + theValues[i] + "\n";
            }
            return returnString;
        }

        private int hashFunction(TKey key)
        {
            return key.GetHashCode() % PRIMEVALUE;
        }
    }
}
