using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    //1.
    public class MyStack<T>
    {
        public int count;
        private List<T> list;
        public MyStack()
        {
            count = 0;
            list = new List<T>();
        }
        public void Push(T ele)
        {
            list.Insert(0, ele);
            count++;
        }
        public T Pop()
        {
                T result = list[0];
                list.RemoveAt(0);
                count--;
                return result;   
        }
        

    }

    public class MyList<T>
    {
        /*
         * void Add (T element)
        2. T Remove (int index)
3. bool Contains (T element)
4. void Clear ()
5. void InsertAt (T element, int index)
6. void DeleteAt (int index)
7. T Find (int index)
         * 
         */
        private List<T> list;

        public MyList()
        {
            list = new List<T>();
        }
        public void Add(T ele)
        {
            list.Add(ele);
        }
        public T Remove(int index)
        {
            T result = list[index];
            list.RemoveAt(index);
            return result;
        }
        public bool Contains(T element)
        { 
            return list.Contains(element);  
        }

        public void Clear()
        {
            list.Clear();
        }

        public void InsertAt(T element, int index)
        {
            list.Insert(index, element);
        }
        public void DeleteAt(int index)
        {
            list.RemoveAt(index);
        }
        public T Find(int index)
        { 
            return (T)list[index];
        }
    }







}
