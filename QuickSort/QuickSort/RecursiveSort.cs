using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class RecursiveSort<T> where T : IComparable<T>
    {
        public void Partition(List<T> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        private void Sort(List<T> list, int start, int end)
        {
            if((end - start) < 1)
            {
                return;
            }
            T pivot = list[end];
            int wall = start;
            for (int i = start; i < end; i++)
            {
                if (list[i].CompareTo(pivot) < 0)
                {
                    T temp = list[wall];
                    list[wall] = list[i];
                    list[i] = temp;
                    wall++;
                }
            }

            T temp1 = list[wall];
            list[wall] = pivot;
            list[end] = temp1;

            //sorting left 
            Sort(list, start, wall - 1);

            //then sort the right
            Sort(list, wall + 1, end);
        }

    }
}
