using System;
using System.Collections;
using System.Collections.Generic;

namespace ClassLibrary1
{
    public class MyList : IList<MyItem>
    {
        List<MyItem> list;
        public MyList()
        {
            list = new List<MyItem>();
        }

        public MyItem this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public int Count { get { return list.Count; } }

        public bool IsReadOnly { get; }

        public void Add(MyItem item)
        {
            list.Add(item);
        }

        public void Clear()
        {
            list.Clear();
        }

        public bool Contains(MyItem item)
        {
            return list.Contains(item);
        }

        public void CopyTo(MyItem[] array, int arrayIndex)
        {
            list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<MyItem> GetEnumerator()
        {
            return list.GetEnumerator();
        }

        public int IndexOf(MyItem item)
        {
            return list.IndexOf(item);
        }

        public void Insert(int index, MyItem item)
        {
            list.Insert(index, item);
        }

        public bool Remove(MyItem item)
        {
            return list.Remove(item);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
