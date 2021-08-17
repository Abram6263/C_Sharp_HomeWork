using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class MyCollection<T> 
    {
        private List<T> data;
        public MyCollection()
        {
            data = new List<T>();
        }
        public T this[int index]
        {
            get { return data[index]; }
        }
        public void AddInList(T item)
        {
            data.Add(item);
        }
        public int GetCount()
        {
            return data.Count;
        }
    }
}
