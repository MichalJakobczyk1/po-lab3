using System;

namespace Classes
{
    public class HistoryArray<T>
    {
        private T[] array = new T[1000];
        private int last = -1;
        public void Add(T item)
        {
            if (last == 1000)
            {
                last = 0;
            }
            array[++last] = item;
        }

        public void Print()
        {
            for (int i = 0; i <= last; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
