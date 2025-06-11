using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson14Task2
{
    internal class Warehous:IEnumerable
    {
        Dictionary<string,int> goods;
        public Warehous()
        {
            goods = new Dictionary<string, int>();
        }
        public int this[string key]
        {
            get => goods[key];
            set => goods[key] = value;
        }
        public void AddGood(string key, int value)
        {
            goods.Add(key, value);
        }
        public void Remove(string key)
        {
            goods.Remove(key);
        }
        public bool Contains(string key) => goods.ContainsKey(key);
        public int? GetValue(string key)
        {
            if(goods.TryGetValue(key, out int value)) 
                return value;
            return null;
        }
        public void ChangeValue(string key, int value, Func<int,int,int> func)
        {
            goods[key] = func(goods[key], value);
        }
        public int Count() => goods.Count;
        public void Clear()
        { goods.Clear(); }

        public IEnumerator GetEnumerator() => goods.GetEnumerator();
        
    }
}
