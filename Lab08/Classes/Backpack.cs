using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections.Classes
{
    public class Backpack<T> : IBag.IBag<T>
    {
        private List<T> contents = new List<T>();
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in contents)
            {
                yield return item;
            }
        }

        public void Pack(T item)
        {
            contents.Add(item);
        }

        public T Unpack(int index)
        {
            T item = contents[index];
            contents.RemoveAt(index);
            return item;
        }

        /*IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }*/

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
