using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDynamicArrayApp.Model
{
    internal class MonoceptDynamicArray<T>
    {
        private T[] items;
        private int count;

        public MonoceptDynamicArray()
        {
            items = new T[5];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, items.Length * 2);
                Console.WriteLine($"Array full. Resizing to {items.Length} elements.");
            }

            items[count] = item;
            count++;
        }

        public T[] GetArray()
        {
            T[] result = new T[count];

            for (int i = 0; i < count; i++)
            {
                result[i] = items[i];
            }

            return result;
        }
    }
}
