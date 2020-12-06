using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class Hoare<T> where T : IComparable
    {
        public void Partition(List<T> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        public void Sort(List<T> list, int start, int end)
        {
            T pivot = list[start];
            int left = -1;
            int right = list.Count;

            while(list[left].CompareTo(pivot) >= 0)
            {
                left++;
            }

            while(list[right].CompareTo(pivot) <= 0)
            {
                right++;
            }

            T temp = list[left];
            list[left] = list[right];
            list[right] = temp;
        }
    }
}
