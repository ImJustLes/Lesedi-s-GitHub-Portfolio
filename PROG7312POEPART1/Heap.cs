using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312POEPART1
{
    public class Heap<T> where T : IComparable<T>
    {
        private List<T> heap;

        public Heap()
        {
            heap = new List<T>();
        }

        public void Insert(T item)
        {
            heap.Add(item);
            int i = heap.Count - 1;
            while (i != 0 && heap[i].CompareTo(heap[(i - 1) / 2]) < 0)
            {
                Swap(i, (i - 1) / 2);
                i = (i - 1) / 2;
            }
        }

        private void Swap(int i, int j)
        {
            T temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public T Find(string searchString)
        {
            int index = heap.FindIndex(x => x.ToString().Equals(searchString, StringComparison.OrdinalIgnoreCase));

            if (index != -1)
                return heap[index];
            else
                return default(T);
        }
    }
}
