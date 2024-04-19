using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class KeyValueList <TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> pairs;

        public KeyValueList() { pairs = new List<KeyValuePair<TKey, TValue>>(); }

        public void Add(TKey key, TValue value) { pairs.Add(new KeyValuePair<TKey, TValue>(key, value)); }

        public int Count {  get { return pairs.Count; } }
        public KeyValuePair<TKey, TValue> this[int index]
        {
            get
            {
                if (index < 0 || index >= pairs.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                return pairs[index];
            }
            set
            {
                if (index < 0 || index >= pairs.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                pairs[index] = value;
            }
        }


    }
    public class HTask
    {
        public HTask() {
            KeyValueList<string, int> valueList = new KeyValueList<string, int> ();
            valueList.Add("one", 1);
            valueList.Add("two", 2);
            valueList.Add("three", 3);
            valueList.Add("four", 3);
            valueList.Add("five", 5);
            valueList.Add("six", 6);
            valueList.Add("seven", 7);
            valueList.Add("eight", 8);
            valueList.Add("nine", 9);
            valueList.Add("ten", 10);

            for (int i = 0; i < valueList.Count; i++) { Console.WriteLine($"{valueList[i].Key} = {valueList[i].Value} "); }
        }
    }
}
